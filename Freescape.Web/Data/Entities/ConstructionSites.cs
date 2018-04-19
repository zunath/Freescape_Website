using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class ConstructionSites
    {
        public ConstructionSites()
        {
            ConstructionSiteComponents = new HashSet<ConstructionSiteComponents>();
        }

        public int ConstructionSiteId { get; set; }
        public int? PcterritoryFlagId { get; set; }
        public string PlayerId { get; set; }
        public int StructureBlueprintId { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }

        public PcterritoryFlags PcterritoryFlag { get; set; }
        public PlayerCharacters Player { get; set; }
        public StructureBlueprints StructureBlueprint { get; set; }
        public ICollection<ConstructionSiteComponents> ConstructionSiteComponents { get; set; }
    }
}
