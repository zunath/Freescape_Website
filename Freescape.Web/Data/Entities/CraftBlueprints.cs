using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class CraftBlueprints
    {
        public CraftBlueprints()
        {
            CraftBlueprintComponents = new HashSet<CraftBlueprintComponents>();
        }

        public long CraftBlueprintId { get; set; }
        public long CraftCategoryId { get; set; }
        public int Level { get; set; }
        public string ItemName { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }
        public int SkillId { get; set; }
        public int CraftDeviceId { get; set; }
        public int? PerkId { get; set; }
        public int RequiredPerkLevel { get; set; }
        public bool IsActive { get; set; }
        public int CraftTierLevel { get; set; }

        public CraftBlueprintCategories CraftCategory { get; set; }
        public CraftDevices CraftDevice { get; set; }
        public Perks Perk { get; set; }
        public Skills Skill { get; set; }
        public ICollection<CraftBlueprintComponents> CraftBlueprintComponents { get; set; }
    }
}
