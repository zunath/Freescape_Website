using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class PerkCategories
    {
        public PerkCategories()
        {
            Perks = new HashSet<Perks>();
        }

        public int PerkCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }

        public ICollection<Perks> Perks { get; set; }
    }
}
