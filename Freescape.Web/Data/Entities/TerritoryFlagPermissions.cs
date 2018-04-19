using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class TerritoryFlagPermissions
    {
        public TerritoryFlagPermissions()
        {
            PcterritoryFlagsPermissions = new HashSet<PcterritoryFlagsPermissions>();
        }

        public int TerritoryFlagPermissionId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsSelectable { get; set; }

        public ICollection<PcterritoryFlagsPermissions> PcterritoryFlagsPermissions { get; set; }
    }
}
