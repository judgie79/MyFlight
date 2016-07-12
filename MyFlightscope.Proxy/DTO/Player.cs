using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    /// <summary>
    /// 
    /// </summary>
    /// <example>
    /// <Player>
    ///     <ID>47687</ID>
    ///     <Firstname>Michael</Firstname>
    ///     <Lastname>Richter</Lastname>
    ///     <DisplayName>Michael Richter</DisplayName>
    ///     <Email>the.judgie@googlemail.com</Email>
    ///     <GenderID>1</GenderID>
    ///     <Gender>Male</Gender>
    ///     <Handedness>RightHanded</Handedness>
    ///     <CommunityConsent>1</CommunityConsent>
    ///     <PgaRegistered>0</PgaRegistered>
    ///     <PlayerParameters>
    ///         <PlayerParameter>
    ///             <ParameterName>Height</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>ArmSpan</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>BirthDate</ParameterName>
    ///             <ParameterValue>1979-10-18 00:00:00</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>City</ParameterName>
    ///             <ParameterValue />
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>Country</ParameterName>
    ///             <ParameterValue>DE</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>Handicap</ParameterName>
    ///             <ParameterValue>32</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>HandSize</ParameterName>
    ///             <ParameterValue />
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>HipHeight</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>HipSize</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>PalmToGround</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>Phone</ParameterName>
    ///             <ParameterValue />
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>PhotoServerTS</ParameterName>
    ///             <ParameterValue>1456172268</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>ShoulderWidth</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>State</ParameterName>
    ///             <ParameterValue>Other</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>Street</ParameterName>
    ///             <ParameterValue />
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>Weight</ParameterName>
    ///             <ParameterValue>0</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>ZipCode</ParameterName>
    ///             <ParameterValue />
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>TokenData</ParameterName>
    ///             <ParameterValue>{D92F726D-86C4-56B6-E3E3-759D0AD1E980}</ParameterValue>
    ///         </PlayerParameter>
    ///         <PlayerParameter>
    ///             <ParameterName>Language</ParameterName>
    ///             <ParameterValue />
    ///         </PlayerParameter>
    ///     </PlayerParameters>
    ///  </Player>
    /// </example>
    public class Player
    {
        public Player()
        {
            PlayerParameters = new PlayerParameters();
        }
        
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("Firstname")]
        public string Firstname { get; set; }

        [XmlElement("Lastname")]
        public string Lastname { get; set; }

        [XmlElement("DisplayName")]
        public string DisplayName { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        [XmlElement("GenderID")]
        public string GenderID { get; set; }

        [XmlElement("Gender")]
        public string Gender { get; set; }

        [XmlElement("Handedness")]
        public string Handedness { get; set; }

        [XmlElement("CommunityConsent")]
        public string CommunityConsent { get; set; }

        [XmlElement("PgaRegistered")]
        public bool PgaRegistered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example>
        ///   <PlayerParameters>
        ///         <PlayerParameter>
        ///             <ParameterName>Height</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>ArmSpan</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>BirthDate</ParameterName>
        ///             <ParameterValue>1979-10-18 00:00:00</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>City</ParameterName>
        ///             <ParameterValue />
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>Country</ParameterName>
        ///             <ParameterValue>DE</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>Handicap</ParameterName>
        ///             <ParameterValue>32</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>HandSize</ParameterName>
        ///             <ParameterValue />
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>HipHeight</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>HipSize</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>PalmToGround</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>Phone</ParameterName>
        ///             <ParameterValue />
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>PhotoServerTS</ParameterName>
        ///             <ParameterValue>1456172268</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>ShoulderWidth</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>State</ParameterName>
        ///             <ParameterValue>Other</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>Street</ParameterName>
        ///             <ParameterValue />
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>Weight</ParameterName>
        ///             <ParameterValue>0</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>ZipCode</ParameterName>
        ///             <ParameterValue />
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>TokenData</ParameterName>
        ///             <ParameterValue>{D92F726D-86C4-56B6-E3E3-759D0AD1E980}</ParameterValue>
        ///         </PlayerParameter>
        ///         <PlayerParameter>
        ///             <ParameterName>Language</ParameterName>
        ///             <ParameterValue />
        ///         </PlayerParameter>
        ///     </PlayerParameters>
        /// </example>
        [XmlElement("PlayerParameters")]
        public PlayerParameters PlayerParameters { get; set; }

        
    }
}