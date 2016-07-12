using System;
using System.Linq;
using System.Text.RegularExpressions;
using MyFlight.Data;
using MyFlightscope.Proxy;

namespace MyFlight.Sync.MFS
{
    public class MyFlighscopeSync : IMyFlighscopeSync
    {
        public const string BAG_BRAND_KEY = "BRAND";
        public const string BAG_TYPE_KEY = "TYPE";
        public const string BAG_MODEL_KEY = "MODEL";

        public const string DEFAULT_BAG_NAMING_PATTERN = "(?<BRAND>.+) - (?<TYPE>.+) \\[(?<MODEL>.+)\\]";

        private IMyFlightscopeLoader loader;
        private IMyFlightscopeParser parser;

        public MyFlighscopeSync(IMyFlightscopeLoader loader, IMyFlightscopeParser parser)
        {
            this.loader = loader;
            this.parser = parser;
        }

        public void Login(string userName, string password)
        {
            loader.Login(userName, password);
        }


        public string BagNamingPattern { get; set; }

        public string BallNamingPattern { get; set; }

        public string ClubNamingPattern { get; set; }

        public void SyncBags(string playerId)
        {
            string xmlResult = loader.LoadBags(playerId, 20, 0);
            MyFlightscope.Proxy.DTO.LoadGolfbagsResult result = this.parser.ParseLoadBags(xmlResult);

            using (MyFlightModel context = new MyFlightModel())
            {
                foreach (var mfsPlayerGolfBag in result.PlayerGolfbags)
                {
                    Bag bag = context.Bags.SingleOrDefault(b => b.MyFlightscopeId == mfsPlayerGolfBag.Golfbag.ID);

                    if (bag == null)
                    {
                        bag = new Bag();
                        bag.MyFlightscopeId = mfsPlayerGolfBag.Golfbag.ID;
                        bag.CreatedOn = DateTime.Now;
                    }

                    if (string.IsNullOrWhiteSpace(BagNamingPattern))
                    {
                        BagNamingPattern = DEFAULT_BAG_NAMING_PATTERN;
                    }

                    Regex rgx = new Regex(BagNamingPattern);
                    Match match = rgx.Match(mfsPlayerGolfBag.Golfbag.DisplayName);
                    string[] names = rgx.GetGroupNames();
                    
                    if (names.Contains(BAG_BRAND_KEY))
                    {
                        bag.Brand = match.Groups[BAG_BRAND_KEY].Value;
                    }

                    if (names.Contains(BAG_MODEL_KEY))
                    {
                        bag.Model = match.Groups[BAG_MODEL_KEY].Value;
                    }

                    if (names.Contains(BAG_TYPE_KEY))
                    {
                        BagType bagType = BagType.Unknown;

                        bool success = Enum.TryParse(match.Groups[BAG_TYPE_KEY].Value, out bagType);

                        bag.BagType = success ? bagType : BagType.Unknown;
                    }
                    
                    bag.IsDeleted = mfsPlayerGolfBag.Golfbag.IsDeleted;
                    bag.IsDefault = mfsPlayerGolfBag.IsDefault;
                    
                    bag.LastSynced = DateTime.Now;

                    foreach (var clubForGolfBag in mfsPlayerGolfBag.Golfbag.ClubsForGolfBag)
                    {
                        Club club = context.Clubs.SingleOrDefault(b => b.MyFlightscopeId == clubForGolfBag.Club.ID);

                        if (club == null)
                        {
                            club = new Club();
                            club.MyFlightscopeId = clubForGolfBag.Club.ID;
                            club.CreatedOn = DateTime.Now;

                            bag.Clubs.Add(club);
                        }

                        club.Brand = clubForGolfBag.Club.Manufacturer;
                        //club.Name = clubForGolfBag.Club.Model;
                        club.Model = clubForGolfBag.Club.Model;
                        club.Loft = Convert.ToDecimal(clubForGolfBag.Club.ClubParameters.SingleOrDefault(c => c.Key == "loft").Value);

                        //ShaftType
                        ShaftType shaftType = ShaftType.Unknown;
                        bool shaftTypeParseSuccess = Enum.TryParse(clubForGolfBag.Club.ClubParameters.SingleOrDefault(c => c.Key == "shaft").Value, out shaftType);
                        club.ShaftType = shaftTypeParseSuccess ? shaftType : ShaftType.Unknown;

                        //ClubType
                        ClubType clubType = ClubType.Unknown;
                        bool clubTypeParseSuccess = Enum.TryParse(clubForGolfBag.Club.ClubType, out clubType);
                        club.ClubType = clubTypeParseSuccess ? clubType : ClubType.Unknown;

                        //ShaftFlex
                        ShaftFlex shaftFlex = ShaftFlex.Unknown;
                        bool shaftFlexParseSuccess = Enum.TryParse(clubForGolfBag.Club.ClubParameters.SingleOrDefault(c => c.Key == "clubFlexEnum").Value, out shaftFlex);
                        club.Flex = shaftFlexParseSuccess ? shaftFlex : ShaftFlex.Unknown;

                        club.SpecializedClubType = clubForGolfBag.Club.ClubParameters.SingleOrDefault(c => c.Key == "ExtendedClubType").Value;
                        
                        
                    }

                    context.SaveChanges();
                }
                
            }
        }

        public void Dispose()
        {
            this.loader.Dispose();
            this.parser.Dispose();
        }
    }
}