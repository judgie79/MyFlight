using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    public class SkillsAssessmentTemplate
    {
        public SkillsAssessmentTemplate()
        {
        }
        
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("DisplayName")]
        public string DisplayName { get; set; }

        [XmlElement("CreateDate")]
        public MyFlightDatetime CreateDate { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("IsMaster")]
        public bool IsMaster { get; set; }

        [XmlElement("UserDef")]
        public string UserDef { get; set; }

        [XmlElement("TemplateIsDeleted")]
        public bool TemplateIsDeleted { get; set; }

        [XmlElement("IsMTT")]
        public bool IsMTT { get; set; }

        [XmlElement("SiteID")]
        public string SiteID { get; set; }

        [XmlElement("SkillsAssessmentTemplateParameters")]
        public SkillsAssessmentTemplateParameters SkillsAssessmentTemplateParameters { get; set; }

        [XmlArray("SkillsAssessmentTargets")]
        public SkillsAssessmentTarget[] SkillsAssessmentTargets { get; set; }
    }
}