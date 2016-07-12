using System.Collections.Generic;
using System.Text;

namespace MyFlight.Sync.MFS
{
    public interface IMyFlighscopeSync
    {
        void Login(string email, string password);

        void SyncBags(string playerId);

        string BagNamingPattern { get; }

        string BallNamingPattern { get; }

        string ClubNamingPattern { get; }
    }
}
