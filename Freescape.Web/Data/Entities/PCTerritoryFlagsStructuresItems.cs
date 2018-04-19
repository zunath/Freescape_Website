namespace Freescape.Web.Data.Entities
{
    public partial class PcterritoryFlagsStructuresItems
    {
        public long PcstructureItemId { get; set; }
        public long PcstructureId { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public PcterritoryFlagsStructures Pcstructure { get; set; }
    }
}
