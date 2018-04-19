namespace Freescape.Web.Data.Entities
{
    public partial class PcterritoryFlagsPermissions
    {
        public int PcterritoryFlagPermissionId { get; set; }
        public int PcterritoryFlagId { get; set; }
        public string PlayerId { get; set; }
        public int TerritoryFlagPermissionId { get; set; }

        public PcterritoryFlags PcterritoryFlag { get; set; }
        public PlayerCharacters Player { get; set; }
        public TerritoryFlagPermissions TerritoryFlagPermission { get; set; }
    }
}
