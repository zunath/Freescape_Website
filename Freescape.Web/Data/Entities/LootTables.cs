using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class LootTables
    {
        public LootTables()
        {
            LootTableItems = new HashSet<LootTableItems>();
        }

        public int LootTableId { get; set; }
        public string Name { get; set; }

        public ICollection<LootTableItems> LootTableItems { get; set; }
    }
}
