using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Plants
    {
        public Plants()
        {
            GrowingPlants = new HashSet<GrowingPlants>();
        }

        public int PlantId { get; set; }
        public string Name { get; set; }
        public int BaseTicks { get; set; }
        public string Resref { get; set; }
        public int WaterTicks { get; set; }
        public int Level { get; set; }

        public ICollection<GrowingPlants> GrowingPlants { get; set; }
    }
}
