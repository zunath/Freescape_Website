using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Pccorpses
    {
        public Pccorpses()
        {
            PccorpseItems = new HashSet<PccorpseItems>();
        }

        public long PccorpseId { get; set; }
        public string Name { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double PositionZ { get; set; }
        public double Orientation { get; set; }
        public string AreaTag { get; set; }

        public ICollection<PccorpseItems> PccorpseItems { get; set; }
    }
}
