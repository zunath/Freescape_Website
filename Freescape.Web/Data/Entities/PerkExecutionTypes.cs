using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class PerkExecutionTypes
    {
        public PerkExecutionTypes()
        {
            Perks = new HashSet<Perks>();
        }

        public int PerkExecutionTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Perks> Perks { get; set; }
    }
}
