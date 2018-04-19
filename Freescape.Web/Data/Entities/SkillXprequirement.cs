namespace Freescape.Web.Data.Entities
{
    public partial class SkillXprequirement
    {
        public int SkillXprequirementId { get; set; }
        public int SkillId { get; set; }
        public int Rank { get; set; }
        public int Xp { get; set; }

        public Skills Skill { get; set; }
    }
}
