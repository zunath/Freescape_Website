using System;

namespace Freescape.Web.Data.Entities
{
    public partial class PcsearchSites
    {
        public int PcsearchSiteId { get; set; }
        public string PlayerId { get; set; }
        public int SearchSiteId { get; set; }
        public DateTime UnlockDateTime { get; set; }

        public PlayerCharacters Player { get; set; }
    }
}
