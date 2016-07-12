using System;
using MyFlightscope.Proxy.DTO;

namespace MyFlightscope.Proxy
{
    public interface IMyFlightscopeParser : IDisposable
    {
        LoadGolfbagsResult ParseLoadBags(string xml);
        LoadSessionsResult ParseLoadSessions(string xml);
        LoadSessionResult ParseLoadSession(string xml);
    }
}