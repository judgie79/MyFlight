using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    [XmlRoot("PlayerGolfbags")]
    public class LoadGolfbagsResult
    {
        [XmlElement("PlayerGolfbag")]
        public PlayerGolfbag[] PlayerGolfbags { get; set; }
    }
}