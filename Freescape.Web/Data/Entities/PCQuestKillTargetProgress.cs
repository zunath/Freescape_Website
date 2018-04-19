namespace Freescape.Web.Data.Entities
{
    public partial class PcquestKillTargetProgress
    {
        public int PcquestKillTargetProgressId { get; set; }
        public string PlayerId { get; set; }
        public int PcquestStatusId { get; set; }
        public int NpcgroupId { get; set; }
        public int RemainingToKill { get; set; }

        public Npcgroups Npcgroup { get; set; }
        public PcquestStatus PcquestStatus { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
