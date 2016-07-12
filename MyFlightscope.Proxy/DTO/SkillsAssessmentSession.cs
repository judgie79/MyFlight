using System.Xml.Serialization;

namespace MyFlightscope.Proxy.DTO
{
    [XmlRoot("Session")]
    public class SkillsAssessmentSession : Session
    {
        [XmlElement("SkillsAssessmentTemplate")]
        public SkillsAssessmentTemplate SkillsAssessmentTemplate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        ///   <SkillsAssessmentTemplate>
        ///     <ID>44794</ID>
        ///     <DisplayName>Test</DisplayName>
        ///     <CreateDate>2016-03-02 20:05:52</CreateDate>
        ///     <Description />
        ///     <isMaster>0</isMaster>
        ///     <UserDef>1</UserDef>
        ///     <TemplateIsDeleted>0</TemplateIsDeleted>
        ///     <isMTT>0</isMTT>
        ///     <SiteID />
        ///     <SkillsAssessmentTemplateParameters>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>Altitude</ParameterName>
        ///           <ParameterValue>0.000</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>HasCompetitionDate</ParameterName>
        ///           <ParameterValue>False</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>IsCombine</ParameterName>
        ///           <ParameterValue>0</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>IsPuttingTemplate</ParameterName>
        ///           <ParameterValue>False</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>MaxExecutionTime</ParameterName>
        ///           <ParameterValue>1800</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>PlayModeRandom</ParameterName>
        ///           <ParameterValue>False</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>SurfaceType</ParameterName>
        ///           <ParameterValue>Soft</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>TemplateDifficulty</ParameterName>
        ///           <ParameterValue>Easy</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///        <SkillsAssessmentTemplateParameter>
        ///           <ParameterName>UserDefined</ParameterName>
        ///           <ParameterValue>1</ParameterValue>
        ///        </SkillsAssessmentTemplateParameter>
        ///     </SkillsAssessmentTemplateParameters>
        ///     <SkillsAssessmentTargets>
        ///        <SkillsAssessmentTarget>
        ///           <ID>115836</ID>
        ///           <AttemptsAtTarget>5</AttemptsAtTarget>
        ///           <TargetIndex>0</TargetIndex>
        ///           <TargetShapeID>5</TargetShapeID>
        ///           <SkillsAssessmentTargetParameters>
        ///              <SkillsAssessmentTargetParameter>
        ///                 <ParameterName>FairwayWidth</ParameterName>
        ///                 <ParameterValue>46.000</ParameterValue>
        ///              </SkillsAssessmentTargetParameter>
        ///              <SkillsAssessmentTargetParameter>
        ///                 <ParameterName>MinDistance</ParameterName>
        ///                 <ParameterValue>200.000</ParameterValue>
        ///              </SkillsAssessmentTargetParameter>
        ///              <SkillsAssessmentTargetParameter>
        ///                 <ParameterName>ZoneSize1</ParameterName>
        ///                 <ParameterValue>0.400000</ParameterValue>
        ///              </SkillsAssessmentTargetParameter>
        ///              <SkillsAssessmentTargetParameter>
        ///                 <ParameterName>ZoneSize2</ParameterName>
        ///                 <ParameterValue>0.600000</ParameterValue>
        ///              </SkillsAssessmentTargetParameter>
        ///              <SkillsAssessmentTargetParameter>
        ///                 <ParameterName>ZoneSize3</ParameterName>
        ///                 <ParameterValue>0.800000</ParameterValue>
        ///              </SkillsAssessmentTargetParameter>
        ///           </SkillsAssessmentTargetParameters>
        ///        </SkillsAssessmentTarget>
        ///     </SkillsAssessmentTargets>
        ///   </SkillsAssessmentTemplate>
        /// </example>
        
    }
}
