using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Perks
    {
        public Perks()
        {
            CraftBlueprints = new HashSet<CraftBlueprints>();
            Pcperks = new HashSet<Pcperks>();
            PerkLevels = new HashSet<PerkLevels>();
            StructureBlueprints = new HashSet<StructureBlueprints>();
        }

        public int PerkId { get; set; }
        public string Name { get; set; }
        public int? FeatId { get; set; }
        public bool IsActive { get; set; }
        public string JavaScriptName { get; set; }
        public int BaseManaCost { get; set; }
        public double BaseCastingTime { get; set; }
        public string Description { get; set; }
        public int PerkCategoryId { get; set; }
        public int? CooldownCategoryId { get; set; }
        public int ExecutionTypeId { get; set; }
        public string ItemResref { get; set; }
        public bool IsTargetSelfOnly { get; set; }

        public CooldownCategories CooldownCategory { get; set; }
        public PerkExecutionTypes ExecutionType { get; set; }
        public PerkCategories PerkCategory { get; set; }
        public ICollection<CraftBlueprints> CraftBlueprints { get; set; }
        public ICollection<Pcperks> Pcperks { get; set; }
        public ICollection<PerkLevels> PerkLevels { get; set; }
        public ICollection<StructureBlueprints> StructureBlueprints { get; set; }
    }
}
