namespace Freescape.Web.Data.Entities
{
    public partial class ConstructionSiteComponents
    {
        public int ConstructionSiteComponentId { get; set; }
        public int ConstructionSiteId { get; set; }
        public int Quantity { get; set; }
        public int StructureComponentId { get; set; }

        public ConstructionSites ConstructionSite { get; set; }
        public StructureComponents StructureComponent { get; set; }
    }
}
