using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class CraftDevices
    {
        public CraftDevices()
        {
            CraftBlueprints = new HashSet<CraftBlueprints>();
        }

        public int CraftDeviceId { get; set; }
        public string Name { get; set; }

        public ICollection<CraftBlueprints> CraftBlueprints { get; set; }
    }
}
