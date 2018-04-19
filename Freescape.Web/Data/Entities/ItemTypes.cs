using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class ItemTypes
    {
        public ItemTypes()
        {
            Items = new HashSet<Items>();
        }

        public int ItemTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Items> Items { get; set; }
    }
}
