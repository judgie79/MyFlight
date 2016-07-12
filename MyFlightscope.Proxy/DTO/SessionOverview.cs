using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    /// <summary>
    /// 
    /// </summary>
    /// <example>
    ///       <Session>
    ///         <sessionID>415902</sessionID>
    ///         <sessionDisplayName>02-MÃ¤rz-2016 21:15</sessionDisplayName>
    ///         <sessionCreateDate>2016-03-02 20:15:16</sessionCreateDate>
    ///         <sessionTypeID>1</sessionTypeID>
    ///         <sessionGuid>BE730733-C1A8-4487-AA98-3A8080BAE1FE</sessionGuid>
    ///         <sessionLocation/>
    ///         <appVersion>IOS_VX_3.0.0</appVersion>
    ///         <sensorModel>8</sensorModel>
    ///         <Players>Michael Richter</Players>
    ///         <templateID/>
    ///         <templateDisplayName/>
    ///       </Session>
    /// </example>
    public class SessionOverview
    {
        [XmlElement("sessionID")]
        public string ID { get; set; }

        [XmlElement("sessionDisplayName")]
        public string DisplayName { get; set; }

        [XmlElement("isDeleted")]
        public bool IsDeleted { get; set; }

        [XmlElement("sessionTypeID")]
        public uint SessionTypeID { get; set; }

        [XmlIgnore]
        public SessionType SessionType { get { return (SessionType)SessionTypeID; } }

        [XmlElement("sessionGuid")]
        public string Guid { get; set; }

        [XmlElement("sessionLocation")]
        public string Location { get; set; }

        [XmlElement("appVersion")]
        public string AppVersion { get; set; }

        [XmlElement("sensorModel")]
        public string SensorModel { get; set; }

        [XmlElement("Players")]
        public string Players { get; set; }

        [XmlElement("templateID")]
        public string TemplateID { get; set; }

        [XmlElement("templateDisplayName")]
        public string TemplateDisplayName { get; set; }
    }
}
