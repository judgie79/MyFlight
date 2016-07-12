using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class Club
    {
        public Club()
        {
            //ClubParameters = new ClubParameters();
        }
        
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("DisplayName")]
        public string DisplayName { get; set; }

        [XmlElement("ClubTypeID")]
        public string ClubTypeID { get; set; }

        [XmlElement("ClubType")]
        public string ClubType { get; set; }

        [XmlElement("Manufacturer")]
        public string Manufacturer { get; set; }

        [XmlElement("Model")]
        public string Model { get; set; }

        [XmlElement("IsMaster")]
        public bool IsMaster { get; set; }

        [XmlElement("Barcode")]
        public string Barcode { get; set; }

        [XmlElement("Photo")]
        public string Photo { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("IsDeleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>  
        /// <example>
        ///   <ClubParameters>
        ///     <ClubParameter>
        ///         <ParameterName>clubFlexEnum</ParameterName>
        ///         <ParameterValue>Regular</ParameterValue>
        ///     </ClubParameter>
        ///     <ClubParameter>
        ///         <ParameterName>ExtendedClubType</ParameterName>
        ///         <ParameterValue>Gap Wedge</ParameterValue>
        ///     </ClubParameter>
        ///     <ClubParameter>
        ///         <ParameterName>loft</ParameterName>
        ///         <ParameterValue>52</ParameterValue>
        ///     </ClubParameter>
        ///     <ClubParameter>
        ///         <ParameterName>shaft</ParameterName>
        ///         <ParameterValue>Steel</ParameterValue>
        ///     </ClubParameter>
        ///   </ClubParameters>
        /// </example>
        [XmlElement("ClubParameters")]
        public ClubParameters ClubParameters { get; set; }

        
    }
}
