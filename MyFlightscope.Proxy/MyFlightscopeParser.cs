using MyFlightscope.Proxy.DTO;
using System.IO;
using System.Xml.Serialization;

namespace MyFlightscope.Proxy
{
    public class MyFlightscopeParser : IMyFlightscopeParser
    {
        public LoadGolfbagsResult ParseLoadBags(string xml)
        {
            LoadGolfbagsResult result;

            XmlSerializer serializer = new XmlSerializer(typeof(LoadGolfbagsResult));
            
            using (TextReader reader = new StringReader(xml))
            {
                result = (LoadGolfbagsResult)serializer.Deserialize(reader);
            }

            return result;
        }

        public LoadSessionsResult ParseLoadSessions(string xml)
        {
            LoadSessionsResult result;

            XmlSerializer serializer = new XmlSerializer(typeof(LoadSessionsResult));

            using (TextReader reader = new StringReader(xml))
            {
                result = (LoadSessionsResult)serializer.Deserialize(reader);
            }

            return result;
        }

        public LoadSessionResult ParseLoadSession(string xml)
        {
            LoadSessionResult result;

            XmlSerializer serializer = new XmlSerializer(typeof(LoadSessionResultProxy));

            using (TextReader reader = new StringReader(xml))
            {
                result = ((LoadSessionResultProxy)serializer.Deserialize(reader)).LoadSessionResult;
            }

            return result;
        }



        public void Dispose()
        {
            
        }

        
    }
}
