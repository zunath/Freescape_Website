using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class StructureComponents
    {
        public StructureComponents()
        {
            ConstructionSiteComponents = new HashSet<ConstructionSiteComponents>();
        }

        public int StructureComponentId { get; set; }
        public int StructureBlueprintId { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public StructureBlueprints StructureBlueprint { get; set; }
        public ICollection<ConstructionSiteComponents> ConstructionSiteComponents { get; set; }
    }
}
