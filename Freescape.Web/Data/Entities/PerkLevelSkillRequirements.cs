namespace Freescape.Web.Data.Entities
{
    public partial class PerkLevelSkillRequirements
    {
        public int PerkLevelSkillRequirementId { get; set; }
        public int PerkLevelId { get; set; }
        public int SkillId { get; set; }
        public int RequiredRank { get; set; }

        public PerkLevels PerkLevel { get; set; }
        public Skills Skill { get; set; }
    }
}
