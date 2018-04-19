namespace Freescape.Web.Data.Entities
{
    public partial class PcsearchSiteItems
    {
        public long PcsearchSiteItemId { get; set; }
        public string PlayerId { get; set; }
        public int SearchSiteId { get; set; }
        public byte[] SearchItem { get; set; }

        public PlayerCharacters Player { get; set; }
    }
}
