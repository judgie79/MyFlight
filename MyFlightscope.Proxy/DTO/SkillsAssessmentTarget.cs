using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class SkillsAssessmentTarget
    {
        public SkillsAssessmentTarget()
        {
            SkillsAssessmentTargetParameters = new SkillsAssessmentTargetParameters();
        }
        
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("AttemptsAtTarget")]
        public int AttemptsAtTarget { get; set; }

        [XmlElement("TargetIndex")]
        public int TargetIndex { get; set; }

        [XmlElement("TargetShapeID")]
        public string TargetShapeID { get; set; }

        [XmlElement("SkillsAssessmentTargetParameters")]
        public SkillsAssessmentTargetParameters SkillsAssessmentTargetParameters { get; set; }
    }
}