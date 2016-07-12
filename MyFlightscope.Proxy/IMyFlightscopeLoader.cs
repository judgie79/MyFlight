using System;

namespace MyFlightscope.Proxy
{
    public interface IMyFlightscopeLoader : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <permission cref="">login required</permission>
        string LoadSessions(string playerID, string filterApp, DateTime filterStartDate, DateTime filterEndDate, string lookingFor, int startIndex, int count);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <permission cref="">login required</permission>
        string LoadSession(string playerID, string sessionID);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <permission cref="">login required</permission>
        string LoadBags(string playerID, int count, int startIndex);

        string LoadSessionLeaderboard(string sessionID, int count = 100, int startIndex = 0);

        string LoadSingleSessionOverview(string sessionID);

        string LoadDashboardStatsForPlayer(string playerID);

        string LoadTotalStatsForPlayer(string playerID);

        void Login(string email, string password);
    }
}