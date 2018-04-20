using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public class LootTable
    {
        public LootTable()
        {
            LootTableItems = new HashSet<LootTableItem>();
        }

        public int LootTableID { get; set; }
        public string Name { get; set; }

        public ICollection<LootTableItem> LootTableItems { get; set; }
    }
}
