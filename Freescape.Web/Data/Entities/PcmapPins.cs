namespace Freescape.Web.Data.Entities
{
    public partial class PcmapPins
    {
        public int PcmapPinId { get; set; }
        public string PlayerId { get; set; }
        public string AreaTag { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public string NoteText { get; set; }

        public PlayerCharacters Player { get; set; }
    }
}
