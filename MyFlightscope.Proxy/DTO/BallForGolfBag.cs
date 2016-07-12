using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class BallForGolfBag
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("BallIndex")]
        public int BallIndex { get; set; }

        [XmlElement("Ball")]
        public Ball Ball { get; set; }
    }
}