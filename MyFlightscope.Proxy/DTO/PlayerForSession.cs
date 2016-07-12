using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class PlayerForSession
    {
        [XmlElement("Player")]
        public Player Player { get; set; }

        [XmlArray("Clubs")]
        public Club[] Clubs { get; set; }

        [XmlArray("Balls")]
        public Ball[] Balls { get; set; }
    }
}