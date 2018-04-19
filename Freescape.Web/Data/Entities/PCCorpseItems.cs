namespace Freescape.Web.Data.Entities
{
    public partial class PccorpseItems
    {
        public long PccorpseItemId { get; set; }
        public long PccorpseId { get; set; }
        public byte[] NwitemObject { get; set; }

        public Pccorpses Pccorpse { get; set; }
    }
}
