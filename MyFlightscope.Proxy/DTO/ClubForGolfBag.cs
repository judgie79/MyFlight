using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class ClubForGolfBag
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("ClubIndex")]
        public int ClubIndex { get; set; }

        [XmlElement("Club")]
        public Club Club { get; set; }
    }
}