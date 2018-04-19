namespace Freescape.Web.Data.Entities
{
    public partial class Pcskills
    {
        public int PcskillId { get; set; }
        public string PlayerId { get; set; }
        public int SkillId { get; set; }
        public int Xp { get; set; }
        public int Rank { get; set; }
        public bool IsLocked { get; set; }

        public PlayerCharacters Player { get; set; }
        public Skills Skill { get; set; }
    }
}
