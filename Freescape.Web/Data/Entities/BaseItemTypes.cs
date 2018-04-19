using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class BaseItemTypes
    {
        public BaseItemTypes()
        {
            PcmigrationItems = new HashSet<PcmigrationItems>();
        }

        public int BaseItemTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<PcmigrationItems> PcmigrationItems { get; set; }
    }
}
