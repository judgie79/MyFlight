using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    /// <summary>
    /// 
    /// </summary>
    /// <example>
    ///   <ID>415911</ID>
    ///   <DisplayName>Test</DisplayName>
    ///   <CreateDate>2016-03-02 20:05:52</CreateDate>
    ///   <SessionTypeID>2</SessionTypeID>
    ///   <SessionType>SkillsAssessmentSession</SessionType>
    ///   <Guid>B2ABEF7C-EEEB-4E6D-8D7F-D360730D1AC1</Guid>
    ///   <Location>location</Location>
    ///   <CreatorID>47687</CreatorID>
    /// </example>
    [XmlRoot("Session")]
    [XmlInclude(typeof(FlightscopeSession))]
    [XmlInclude(typeof(SkillsAssessmentSession))]
    public abstract class Session
    {
        public Session()
        {
            SessionParameters = new SessionParameters();
        }
        
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("DisplayName")]
        public string DisplayName { get; set; }

        [XmlElement("CreateDate")]
        public MyFlightDatetime CreateDate { get; set; }

        [XmlElement("SessionTypeID")]
        public string SessionTypeID { get; set; }

        [XmlElement("SessionType")]
        public SessionType SessionType { get; set; }

        [XmlElement("Guid")]
        public string Guid { get; set; }

        [XmlElement("Location")]
        public string Location { get; set; }

        [XmlElement("CreatorID")]
        public string CreatorID { get; set; }

        [XmlElement("SessionParameters")]
        public SessionParameters SessionParameters { get; set; }

        [XmlArray("PlayerForSessions")]
        public PlayerForSession[] PlayerForSessions { get; set; }

        //public class GolfSwing
        //{
        //    public string GolfSwingID { get; set; }
        //    public string PlayerID { get; set; }
        //    public string ClubID { get; set; }
        //    public string BallID { get; set; }
        //    public string SwingIndex { get; set; }
        //    public string ClubTypeID { get; set; }
        //    public string FocusBandData { get; set; }

        //    /// <summary>
        //    /// 
        //    /// </summary>
        //    /// <example>
        //    ///  <GolfSwingParameter>
        //    ///      <ParameterName>SHOTTIME_PARAMETER_STRING</ParameterName>
        //    ///      <ParameterValue>0</ParameterValue>
        //    ///  </GolfSwingParameter>
        //    ///  <GolfSwingParameter>
        //    ///      <ParameterName>ATTEMPTINDEX_PARAMETER_STRING</ParameterName>
        //    ///      <ParameterValue>0</ParameterValue>
        //    ///  </GolfSwingParameter>
        //    ///  <GolfSwingParameter>
        //    ///      <ParameterName>SHOTSCORE_PARAMETER_STRING</ParameterName>
        //    ///      <ParameterValue>0</ParameterValue>
        //    ///  </GolfSwingParameter>
        //    ///  <GolfSwingParameter>
        //    ///      <ParameterName>TARGETINDEX_PARAMETER_STRING</ParameterName>
        //    ///      <ParameterValue>0</ParameterValue>
        //    ///  </GolfSwingParameter>
        //    ///  <GolfSwingParameter>
        //    ///      <ParameterName>DETECTION_MODE_PARAMETER_STRING</ParameterName>
        //    ///      <ParameterValue>2</ParameterValue>
        //    ///  </GolfSwingParameter>
        //    /// </example>
        //    public IDictionary<string, string> GolfSwingParameters { get; set; }



        //    /// <summary>
        //    /// 
        //    /// </summary>
        //    /// <example>
        //    ///   <Result>
        //    ///     <ID>13385622</ID>
        //    ///     <IsInvalid>0</IsInvalid>
        //    ///     <IsDeleted>0</IsDeleted>
        //    ///     <ShotDateTime>2016-03-02 21:15:48</ShotDateTime>
        //    ///     <ResultTypeID>1</ResultTypeID>
        //    ///     <ResultType>Golf</ResultType>
        //    ///     <pmData>0</pmData>
        //    ///     <ResultParameters>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYX3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYY1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-0.006096</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LATERAL_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>17.88</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYY1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYY5_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-0.064366</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYZ2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYX5_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-0.006519</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>DCOR_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>BACKSPIN_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>7525</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYY1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYZ2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYZ3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>APPLIEDNEGZROTATION_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>CLUBHEADSPEED_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>24.585</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYZ3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-3.703786</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYZ1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-0.052584</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LAUNCHAZIM_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>19.67</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYY3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>IMPACTELEV_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-23.314</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>CLUBHEADSPEEDPOST_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>18.871</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYZ1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>SIDESPIN_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>2416</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>TRACKTIME_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>2.008</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>CARRYDIST_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>46.308</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYX2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYZ1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYY2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYZ3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYX1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYX1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0.118359</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LAUNCHSPEED_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>26.252</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYX1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYZ4_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-0.033849</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYZ2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>8.194237</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>HEIGHT_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>4.427</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>SMASH_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>1.068</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYY4_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0.595209</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYX3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYY2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POSTCLUBPOLYX2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYX4_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0.0626</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYX3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-0.277432</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYX2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>8.394464</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYY2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>23.469774</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>FLIGHTTIME_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>2.215</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LAUNCHELEV_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>18.201</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYZ5_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0.018594</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>PRECLUBPOLYY3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>0</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>POLYY3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-2.892801</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LANDINGVELOCITY1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>7.804</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LANDINGVELOCITY2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>16.632999</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LANDINGVELOCITY3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-7.918</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LANDINGSPINRPM1_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>1598</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LANDINGSPINRPM2_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>6858</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>LANDINGSPINRPM3_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>-2443</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>TotalDist_PARAMETER_STRING</ParameterName>
        //    ///             <ParameterValue>54.819</ParameterValue>
        //    ///         </ResultParameter>
        //    ///         <ResultParameter>
        //    ///             <ParameterName>SURFACE_TYPE_PARAMETR_STRING</ParameterName>
        //    ///             <ParameterValue>2</ParameterValue>
        //    ///         </ResultParameter>
        //    ///     </ResultParameters>
        //    ///     <RollDistance>8.5298910140991</RollDistance>
        //    ///     <TotalDistance>54.818870544434</TotalDistance>
        //    ///     <BounceRoll>
        //    ///         <Point>
        //    ///             <Pos>17.874326705933;42.705673217773;0.0057736304588616</Pos>
        //    ///             <Time>0</Time>
        //    ///         </Point>
        //    ///         <Point>
        //    ///             <Pos>17.948080062866;42.862869262695;0.10051985830069</Pos>
        //    ///             <Time>0.029999999329448</Time>
        //    ///         </Point>
        //    ///     </BounceRoll>
        //    ///     <surfaceType>2: 2</surfaceType>
        //    ///   </Result>
        //    /// </example>
        //    public class Result
        //    {
        //        public string ID { get; set; }
        //        public string IsInvalid { get; set; }
        //        public string IsDeleted { get; set; }
        //        public string ShotDateTime { get; set; }
        //        public string ResultTypeID { get; set; }
        //        public string ResultType { get; set; }
        //        public string PmData { get; set; }

        //        public string RollDistance { get; set; }
        //        public string TotalDistance { get; set; }

        //        public string SurfaceType { get; set; }

        //        /// <summary>
        //        /// 
        //        /// </summary>
        //        /// <example>
        //        ///     <ResultParameters>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYX3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYY1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-0.006096</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LATERAL_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>17.88</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYY1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYY5_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-0.064366</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYZ2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYX5_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-0.006519</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>DCOR_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>BACKSPIN_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>7525</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYY1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYZ2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYZ3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>APPLIEDNEGZROTATION_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>CLUBHEADSPEED_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>24.585</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYZ3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-3.703786</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYZ1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-0.052584</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LAUNCHAZIM_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>19.67</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYY3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>IMPACTELEV_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-23.314</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>CLUBHEADSPEEDPOST_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>18.871</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYZ1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>SIDESPIN_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>2416</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>TRACKTIME_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>2.008</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>CARRYDIST_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>46.308</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYX2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYZ1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYY2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYZ3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYX1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYX1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0.118359</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LAUNCHSPEED_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>26.252</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYX1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYZ4_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-0.033849</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYZ2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>8.194237</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>HEIGHT_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>4.427</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>SMASH_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>1.068</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYY4_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0.595209</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYX3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYY2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POSTCLUBPOLYX2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYX4_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0.0626</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYX3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-0.277432</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYX2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>8.394464</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYY2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>23.469774</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>FLIGHTTIME_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>2.215</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LAUNCHELEV_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>18.201</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYZ5_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0.018594</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>PRECLUBPOLYY3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>0</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>POLYY3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-2.892801</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LANDINGVELOCITY1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>7.804</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LANDINGVELOCITY2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>16.632999</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LANDINGVELOCITY3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-7.918</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LANDINGSPINRPM1_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>1598</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LANDINGSPINRPM2_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>6858</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>LANDINGSPINRPM3_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>-2443</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>TotalDist_PARAMETER_STRING</ParameterName>
        //        ///             <ParameterValue>54.819</ParameterValue>
        //        ///         </ResultParameter>
        //        ///         <ResultParameter>
        //        ///             <ParameterName>SURFACE_TYPE_PARAMETR_STRING</ParameterName>
        //        ///             <ParameterValue>2</ParameterValue>
        //        ///         </ResultParameter>
        //        ///     </ResultParameters>
        //        /// </example>
        //        public IDictionary<string, string> ResultParameters { get; set; }

        //        public IEnumerable<Point> BounceRoll { get; set; }

        //        public class Point
        //        {
        //            public string Pos { get; set; }
        //            public string Time { get; set; }
        //        }
        //    }
        //}

    }
}
