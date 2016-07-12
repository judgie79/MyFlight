using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class Ball
    {
        public Ball()
        {
            //BallParameters = new BallParameters();
        }
        
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("DisplayName")]
        public string DisplayName { get; set; }

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
        ///     <BallParameters>
        ///         <BallParameter>
        ///             <ParameterName>isRangeBall</ParameterName>
        ///             <ParameterValue>1</ParameterValue>
        ///         </BallParameter>
        ///     </BallParameters>
        /// </example>
        [XmlElement("BallParameters")]
        public BallParameters BallParameters { get; set; }

        [XmlIgnore]
        public bool IsRangeBall
        {
            get
            {
                if (BallParameters.ContainsKey("isRangeBall"))
                {
                    return BallParameters["isRangeBall"].Equals("1");
                }

                return false;
            }
        }
    }
}
