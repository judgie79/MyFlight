using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class Golfbag
    {
        public Golfbag()
        {
        }

        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("DisplayName")]
        public string DisplayName { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("CreateDate")]
        public MyFlightDatetime CreateDate { get; set; }

        [XmlElement("DateModified")]
        public MyFlightDatetime DateModified { get; set; }

        [XmlElement("IsDeleted")]
        public bool IsDeleted { get; set; }

        [XmlArray("BallsForGolfBag")]
        public BallForGolfBag[] BallsForGolfBag { get; set; }

        [XmlArray("ClubsForGolfBag")]
        public ClubForGolfBag[] ClubsForGolfBag { get; set; }
    }
}
