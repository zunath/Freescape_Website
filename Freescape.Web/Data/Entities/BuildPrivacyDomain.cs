using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class BuildPrivacyDomain
    {
        public BuildPrivacyDomain()
        {
            PcterritoryFlags = new HashSet<PcterritoryFlags>();
        }

        public int BuildPrivacyTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<PcterritoryFlags> PcterritoryFlags { get; set; }
    }
}
