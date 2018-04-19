using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class StructureBlueprints
    {
        public StructureBlueprints()
        {
            ConstructionSites = new HashSet<ConstructionSites>();
            PcterritoryFlags = new HashSet<PcterritoryFlags>();
            PcterritoryFlagsStructures = new HashSet<PcterritoryFlagsStructures>();
            StructureComponents = new HashSet<StructureComponents>();
        }

        public int StructureBlueprintId { get; set; }
        public int StructureCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Resref { get; set; }
        public bool IsActive { get; set; }
        public bool IsTerritoryFlag { get; set; }
        public bool IsUseable { get; set; }
        public int ItemStorageCount { get; set; }
        public int VanityCount { get; set; }
        public double MaxBuildDistance { get; set; }
        public int Level { get; set; }
        public int? PerkId { get; set; }
        public int RequiredPerkLevel { get; set; }
        public bool GivesSkillXp { get; set; }
        public int SpecialCount { get; set; }
        public bool IsVanity { get; set; }
        public bool IsSpecial { get; set; }
        public int CraftTierLevel { get; set; }

        public Perks Perk { get; set; }
        public StructureCategories StructureCategory { get; set; }
        public ICollection<ConstructionSites> ConstructionSites { get; set; }
        public ICollection<PcterritoryFlags> PcterritoryFlags { get; set; }
        public ICollection<PcterritoryFlagsStructures> PcterritoryFlagsStructures { get; set; }
        public ICollection<StructureComponents> StructureComponents { get; set; }
    }
}
