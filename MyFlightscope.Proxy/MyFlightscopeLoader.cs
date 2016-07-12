using MyFlight.Lib;
using System;
using System.Collections.Specialized;
using System.Text;

namespace MyFlightscope.Proxy
{

    public class MyFlightscopeLoader : IMyFlightscopeLoader
    {
        private const string WS_URL = "http://myflightscope.com/SoapFrame/index.php";
        private const string LOGIN_URL = "http://myflightscope.com/wp-login.php";
        private const string DATEFORMAT = "yyyy-MM-dd";

        private CookieWebClient wc;

        public MyFlightscopeLoader()
        {
            wc = new CookieWebClient();
            wc.Encoding = new UTF8Encoding();
        }

        private const string LOADSESSIONS_URLFORMAT = "{0}?playerID={1}&filterApp={2}&filterStartDate={3}&filterEndDate={4}&lookingFor={5}&startIndex={6}&count={7}&method=listSessionsWithScoreForPlayerAndFilter";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <permission cref="">login required</permission>
        public string LoadSessions(string playerID, string filterApp, DateTime filterStartDate, DateTime filterEndDate, string lookingFor, int startIndex, int count)
        {
            string url = string.Format(LOADSESSIONS_URLFORMAT, WS_URL, playerID, filterApp, filterStartDate.ToString(DATEFORMAT), filterEndDate.ToString(DATEFORMAT), lookingFor, startIndex, count);

            return wc.DownloadString(url);
        }

        private const string LOADBSESSION_URLFORMAT = "{0}?playerID={1}&sessionID={2}&method=getSession";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <permission cref="">login required</permission>
        public string LoadSession(string playerID, string sessionID)
        {
            string url = string.Format(LOADBSESSION_URLFORMAT, WS_URL, playerID, sessionID);

            return wc.DownloadString(url);
        }

        private const string LOADBAGS_URLFORMAT = "{0}?PlayerID={1}&count={2}&method=getPlayerGolfbags&startIndex={3}";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <permission cref="">login required</permission>
        public string LoadBags(string playerID, int count, int startIndex)
        {
            string url = string.Format(LOADBAGS_URLFORMAT, WS_URL, playerID, count, startIndex);

            return wc.DownloadString(url);
        }

        public string LoadSessionLeaderboard(string sessionID, int count = 100, int startIndex = 0)
        {
            //http://myflightscope.com/SoapFrame/index.php?count=100&method=getSessionLeaderBoard&sessionID=415911&startIndex=0
            throw new NotImplementedException();
        }

        public string LoadSingleSessionOverview(string sessionID)
        {
            //http://myflightscope.com/SoapFrame/index.php?SessionID=415911&method=getSingleSessionOverview
            throw new NotImplementedException();
        }

        public string LoadDashboardStatsForPlayer(string playerID)
        {
            //http://myflightscope.com/SoapFrame/index.php?playerID=47687&method=getDashboardStatsForPlayer
            throw new NotImplementedException();
        }

        public string LoadTotalStatsForPlayer(string playerID)
        {
            //http://myflightscope.com/SoapFrame/index.php?playerID=47687&method=getTotalStatsForPlayer
            throw new NotImplementedException();
        }

        public void Login(string email, string password)
        {
            var loginData = new NameValueCollection
            {
                { "log", email },
                { "pwd", password },
                { "rememberme", "forever" },
                { "testcookie", "1" },
                { "redirect_to", "/" }
            };

            // Login into the website (at this point the Cookie Container will do the rest of the job for us, and save the cookie for the next calls)
            wc.UploadValues(LOGIN_URL, "POST", loginData);
        }

        public void Dispose()
        {
            wc.Dispose();
        }
    }

    
}
