using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Pcmigrations
    {
        public Pcmigrations()
        {
            PcmigrationItems = new HashSet<PcmigrationItems>();
        }

        public int PcmigrationId { get; set; }
        public string Name { get; set; }

        public ICollection<PcmigrationItems> PcmigrationItems { get; set; }
    }
}
