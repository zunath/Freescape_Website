using System;

namespace Freescape.Web.Data.Entities
{
    public partial class Pcperks
    {
        public int PcperkId { get; set; }
        public string PlayerId { get; set; }
        public DateTime AcquiredDate { get; set; }
        public int PerkId { get; set; }
        public int PerkLevel { get; set; }

        public Perks Perk { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
