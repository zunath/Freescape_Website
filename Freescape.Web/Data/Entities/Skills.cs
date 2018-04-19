using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Skills
    {
        public Skills()
        {
            CraftBlueprints = new HashSet<CraftBlueprints>();
            Items = new HashSet<Items>();
            Pcskills = new HashSet<Pcskills>();
            PerkLevelSkillRequirements = new HashSet<PerkLevelSkillRequirements>();
            SkillXprequirement = new HashSet<SkillXprequirement>();
        }

        public int SkillId { get; set; }
        public int SkillCategoryId { get; set; }
        public string Name { get; set; }
        public int MaxRank { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public int Primary { get; set; }
        public int Secondary { get; set; }
        public int Tertiary { get; set; }

        public Entities.Attributes PrimaryNavigation { get; set; }
        public Entities.Attributes SecondaryNavigation { get; set; }
        public SkillCategories SkillCategory { get; set; }
        public Entities.Attributes TertiaryNavigation { get; set; }
        public ICollection<CraftBlueprints> CraftBlueprints { get; set; }
        public ICollection<Items> Items { get; set; }
        public ICollection<Pcskills> Pcskills { get; set; }
        public ICollection<PerkLevelSkillRequirements> PerkLevelSkillRequirements { get; set; }
        public ICollection<SkillXprequirement> SkillXprequirement { get; set; }
    }
}
