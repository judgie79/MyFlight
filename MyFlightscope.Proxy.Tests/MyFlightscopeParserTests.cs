using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFlightscope.Proxy.DTO;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;

namespace MyFlightscope.Proxy.Tests
{
    [TestClass]
    public class MyFlightscopeParserTests
    {
        [TestMethod]
        public void TestParseLoadBags()
        {
            string path = "TestResults/LoadBagResults.xml";

            string input = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }

            MyFlightscopeParser myFlightscopeParser = new MyFlightscopeParser();
            LoadGolfbagsResult result = myFlightscopeParser.ParseLoadBags(input);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.PlayerGolfbags);
            Assert.IsTrue(result.PlayerGolfbags.Count() > 0);
        }

        [TestMethod]
        public void TestParseLoadSessions()
        {
            string path = "TestResults/LoadSessionsResult.xml";

            string input = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }

            MyFlightscopeParser myFlightscopeParser = new MyFlightscopeParser();
            LoadSessionsResult result = myFlightscopeParser.ParseLoadSessions(input);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Sessions);
            Assert.IsTrue(result.Sessions.Count() > 0);
            Assert.IsTrue(result.Total == result.Sessions.Count());
            Assert.IsTrue(result.Total == result.RecordCount);
        }

        [TestMethod]
        public void TestParseLoadFlightscopeSession()
        {
            string path = "TestResults/LoadFlightScopeSessionResult.xml";

            string input = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }

            MyFlightscopeParser myFlightscopeParser = new MyFlightscopeParser();
            LoadSessionResult result = myFlightscopeParser.ParseLoadSession(input);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Session);
        }

        [TestMethod]
        public void TestParseFlightscopeSession()
        {
            string path = "TestResults/FlightScopeSession.xml";

            string input = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }


            FlightscopeSession result = null;
            XmlSerializer serializer = new XmlSerializer(typeof(FlightscopeSession));
            using (TextReader reader = new StringReader(input))
            {
                result = (FlightscopeSession)serializer.Deserialize(reader);
            }

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestParseSkillsAssessmentSession()
        {
            string path = "TestResults/SkillsAssessmentSession.xml";

            string input = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }


            SkillsAssessmentSession result = null;
            XmlSerializer serializer = new XmlSerializer(typeof(SkillsAssessmentSession));
            using (TextReader reader = new StringReader(input))
            {
                result = (SkillsAssessmentSession)serializer.Deserialize(reader);
            }

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestParseLoadSkillsAssessmentSession()
        {
            string path = "TestResults/LoadSkillsAssessmentSessionResult.xml";

            string input = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }

            MyFlightscopeParser myFlightscopeParser = new MyFlightscopeParser();
            LoadSessionResult result = myFlightscopeParser.ParseLoadSession(input);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Session);
        }
    }
}
