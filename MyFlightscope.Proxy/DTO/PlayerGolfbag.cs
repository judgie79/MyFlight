using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class PlayerGolfbag
    {
        [XmlElement("GolfbagIndex")]
        public int GolfbagIndex { get; set; }

        [XmlElement("IsDefault")]
        public bool IsDefault { get; set; }

        [XmlElement("Golfbag")]
        public Golfbag Golfbag { get; set; }
    }
}