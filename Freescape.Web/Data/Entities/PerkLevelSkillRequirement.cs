namespace Freescape.Web.Data.Entities
{
    public class PerkLevelSkillRequirement
    {
        public int PerkLevelSkillRequirementID { get; set; }
        public int PerkLevelID { get; set; }
        public int SkillID { get; set; }
        public int RequiredRank { get; set; }

        public PerkLevel PerkLevel { get; set; }
        public Skill Skill { get; set; }
    }
}
