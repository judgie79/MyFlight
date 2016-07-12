using System;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    [XmlRoot("Sessions")]
    public class LoadSessionResultProxy : IXmlSerializable
    {
        public LoadSessionResult LoadSessionResult { get; set; }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            var sessions = XElement.ReadFrom(reader) as XElement;

            var sessionElement = sessions.Element("Session");

            int sessionTypeValue = Convert.ToInt32(sessionElement.Element("SessionTypeID").Value);
            XmlSerializer sessionSerializer;

            switch ((SessionType)sessionTypeValue)
            {
                case SessionType.FlightScopeSession:
                    sessionSerializer = new XmlSerializer(typeof(FlightscopeSession));
                    break;
                case SessionType.SkillsAssessmentSession:
                    sessionSerializer = new XmlSerializer(typeof(SkillsAssessmentSession));
                    break;
                default:
                    sessionSerializer = new XmlSerializer(typeof(FlightscopeSession));
                    break;

            }
            var innerReader = sessionElement.CreateReader();
            LoadSessionResult = new LoadSessionResult();

            LoadSessionResult.Session = ((Session)sessionSerializer.Deserialize(innerReader));

        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}