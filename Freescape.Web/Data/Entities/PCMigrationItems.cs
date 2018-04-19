namespace Freescape.Web.Data.Entities
{
    public partial class PcmigrationItems
    {
        public int PcmigrationItemId { get; set; }
        public int PcmigrationId { get; set; }
        public string CurrentResref { get; set; }
        public string NewResref { get; set; }
        public bool StripItemProperties { get; set; }
        public int BaseItemTypeId { get; set; }

        public BaseItemTypes BaseItemType { get; set; }
        public Pcmigrations Pcmigration { get; set; }
    }
}
