using System;

namespace Freescape.Web.Data.Entities
{
    public partial class GrowingPlants
    {
        public int GrowingPlantId { get; set; }
        public int PlantId { get; set; }
        public int RemainingTicks { get; set; }
        public string LocationAreaTag { get; set; }
        public string LocationX { get; set; }
        public string LocationY { get; set; }
        public string LocationZ { get; set; }
        public string LocationOrientation { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public int TotalTicks { get; set; }
        public int WaterStatus { get; set; }
        public int LongevityBonus { get; set; }

        public Plants Plant { get; set; }
    }
}
