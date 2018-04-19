using System;

namespace Freescape.Web.Data.Entities
{
    public partial class Pccooldowns
    {
        public int PccooldownId { get; set; }
        public string PlayerId { get; set; }
        public int CooldownCategoryId { get; set; }
        public DateTime DateUnlocked { get; set; }

        public CooldownCategories CooldownCategory { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
