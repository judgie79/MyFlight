using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace MyFlightscope.Proxy.Tests
{
    [TestClass]
    public class MyFlightscopeLoaderTests
    {
        private static readonly string userName = ConfigurationManager.AppSettings["MyFlightScopeUsername"];
        private static readonly string password = ConfigurationManager.AppSettings["MyFlightScopePassword"];
        private static readonly string playerId = ConfigurationManager.AppSettings["MyFlightScopePlayerId"];
        private static readonly string FlightScopeSessionId = ConfigurationManager.AppSettings["FlightScopeSessionId"];
        private static readonly string SkillAssessmentSessionId = ConfigurationManager.AppSettings["SkillAssessmentSessionId"];

        [TestMethod]
        public void TestLoadBags()
        {
            using (var client = new MyFlightscopeLoader())
            {
                client.Login(userName, password);


                string result = client.LoadBags(playerId, 20, 0);

                Assert.IsFalse(string.IsNullOrWhiteSpace(result));
            }
        }

        [TestMethod]
        public void TestLoadSessions()
        {
            using (var client = new MyFlightscopeLoader())
            {
                client.Login(userName, password);


                string result = client.LoadSessions(playerId, "ALL", new DateTime(2016, 1, 1), DateTime.Now.Date, string.Empty, 0, 20);

                Assert.IsFalse(string.IsNullOrWhiteSpace(result));
            }
        }

        [TestMethod]
        public void TestLoadFlightscopeSession()
        {
            using (var client = new MyFlightscopeLoader())
            {
                client.Login(userName, password);


                string result = client.LoadSession(playerId, FlightScopeSessionId);

                Assert.IsFalse(string.IsNullOrWhiteSpace(result));
            }
        }

        [TestMethod]
        public void TestLoadSkillsAssessmentSession()
        {
            using (var client = new MyFlightscopeLoader())
            {
                client.Login(userName, password);


                string result = client.LoadSession(playerId, SkillAssessmentSessionId);

                Assert.IsFalse(string.IsNullOrWhiteSpace(result));
            }
        }
    }
}
