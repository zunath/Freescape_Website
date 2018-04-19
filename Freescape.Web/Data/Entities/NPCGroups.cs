using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Npcgroups
    {
        public Npcgroups()
        {
            PcquestKillTargetProgress = new HashSet<PcquestKillTargetProgress>();
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
        }

        public int NpcgroupId { get; set; }
        public string Name { get; set; }

        public ICollection<PcquestKillTargetProgress> PcquestKillTargetProgress { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
    }
}
