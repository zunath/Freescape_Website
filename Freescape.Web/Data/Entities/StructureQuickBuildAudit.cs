using System;

namespace Freescape.Web.Data.Entities
{
    public partial class StructureQuickBuildAudit
    {
        public int StructureQuickBuildId { get; set; }
        public int? PcterritoryFlagId { get; set; }
        public long? PcterritoryFlagStructureId { get; set; }
        public string Dmname { get; set; }
        public DateTime DateBuilt { get; set; }

        public PcterritoryFlags PcterritoryFlag { get; set; }
        public PcterritoryFlagsStructures PcterritoryFlagStructure { get; set; }
    }
}
