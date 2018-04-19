using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class CooldownCategories
    {
        public CooldownCategories()
        {
            Pccooldowns = new HashSet<Pccooldowns>();
            Perks = new HashSet<Perks>();
        }

        public int CooldownCategoryId { get; set; }
        public string Name { get; set; }
        public double BaseCooldownTime { get; set; }

        public ICollection<Pccooldowns> Pccooldowns { get; set; }
        public ICollection<Perks> Perks { get; set; }
    }
}
