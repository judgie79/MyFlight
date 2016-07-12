using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    [XmlRoot("Sessions")]
    public class LoadSessionsResult
    {
        [XmlAttribute("recordCount")]
        public int RecordCount { get; set; }
        
        [XmlElement("Session")]
        public SessionOverview[] Sessions { get; set; }

        [XmlElement("Total")]
        public int Total { get; set; }
    }
}