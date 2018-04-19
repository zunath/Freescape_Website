using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class PerkLevels
    {
        public PerkLevels()
        {
            PerkLevelSkillRequirements = new HashSet<PerkLevelSkillRequirements>();
        }

        public int PerkLevelId { get; set; }
        public int PerkId { get; set; }
        public int Level { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Perks Perk { get; set; }
        public ICollection<PerkLevelSkillRequirements> PerkLevelSkillRequirements { get; set; }
    }
}
