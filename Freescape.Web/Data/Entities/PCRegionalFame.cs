namespace Freescape.Web.Data.Entities
{
    public partial class PcregionalFame
    {
        public int PcregionalFameId { get; set; }
        public string PlayerId { get; set; }
        public int FameRegionId { get; set; }
        public int Amount { get; set; }

        public FameRegions FameRegion { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
