using System;
using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class PlayerCharacters
    {
        public PlayerCharacters()
        {
            ChatLogReceiverPlayer = new HashSet<ChatLog>();
            ChatLogSenderPlayer = new HashSet<ChatLog>();
            ClientLogEvents = new HashSet<ClientLogEvents>();
            ConstructionSites = new HashSet<ConstructionSites>();
            Pccooldowns = new HashSet<Pccooldowns>();
            PccustomEffects = new HashSet<PccustomEffects>();
            PckeyItems = new HashSet<PckeyItems>();
            PcmapPins = new HashSet<PcmapPins>();
            PcoverflowItems = new HashSet<PcoverflowItems>();
            Pcperks = new HashSet<Pcperks>();
            PcquestKillTargetProgress = new HashSet<PcquestKillTargetProgress>();
            PcquestStatus = new HashSet<PcquestStatus>();
            PcregionalFame = new HashSet<PcregionalFame>();
            PcsearchSiteItems = new HashSet<PcsearchSiteItems>();
            PcsearchSites = new HashSet<PcsearchSites>();
            Pcskills = new HashSet<Pcskills>();
            PcterritoryFlags = new HashSet<PcterritoryFlags>();
            PcterritoryFlagsPermissions = new HashSet<PcterritoryFlagsPermissions>();
        }

        public string PlayerId { get; set; }
        public string CharacterName { get; set; }
        public int HitPoints { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public int MaxHunger { get; set; }
        public int CurrentHunger { get; set; }
        public int CurrentHungerTick { get; set; }
        public int UnallocatedSp { get; set; }
        public DateTime? NextSpresetDate { get; set; }
        public int NumberOfSpresets { get; set; }
        public int ResetTokens { get; set; }
        public DateTime? NextResetTokenReceiveDate { get; set; }
        public int HpregenerationAmount { get; set; }
        public int RegenerationTick { get; set; }
        public int RegenerationRate { get; set; }
        public int VersionNumber { get; set; }
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public int CurrentManaTick { get; set; }
        public int RevivalStoneCount { get; set; }
        public string RespawnAreaTag { get; set; }
        public double RespawnLocationX { get; set; }
        public double RespawnLocationY { get; set; }
        public double RespawnLocationZ { get; set; }
        public double RespawnLocationOrientation { get; set; }
        public DateTime? DateLastForcedSpreset { get; set; }
        public DateTime DateSanctuaryEnds { get; set; }
        public bool IsSanctuaryOverrideEnabled { get; set; }
        public int Strbase { get; set; }
        public int Dexbase { get; set; }
        public int Conbase { get; set; }
        public int Intbase { get; set; }
        public int Wisbase { get; set; }
        public int Chabase { get; set; }
        public int TotalSpacquired { get; set; }
        public bool? DisplayHelmet { get; set; }

        public Pcoutfits Pcoutfits { get; set; }
        public ICollection<ChatLog> ChatLogReceiverPlayer { get; set; }
        public ICollection<ChatLog> ChatLogSenderPlayer { get; set; }
        public ICollection<ClientLogEvents> ClientLogEvents { get; set; }
        public ICollection<ConstructionSites> ConstructionSites { get; set; }
        public ICollection<Pccooldowns> Pccooldowns { get; set; }
        public ICollection<PccustomEffects> PccustomEffects { get; set; }
        public ICollection<PckeyItems> PckeyItems { get; set; }
        public ICollection<PcmapPins> PcmapPins { get; set; }
        public ICollection<PcoverflowItems> PcoverflowItems { get; set; }
        public ICollection<Pcperks> Pcperks { get; set; }
        public ICollection<PcquestKillTargetProgress> PcquestKillTargetProgress { get; set; }
        public ICollection<PcquestStatus> PcquestStatus { get; set; }
        public ICollection<PcregionalFame> PcregionalFame { get; set; }
        public ICollection<PcsearchSiteItems> PcsearchSiteItems { get; set; }
        public ICollection<PcsearchSites> PcsearchSites { get; set; }
        public ICollection<Pcskills> Pcskills { get; set; }
        public ICollection<PcterritoryFlags> PcterritoryFlags { get; set; }
        public ICollection<PcterritoryFlagsPermissions> PcterritoryFlagsPermissions { get; set; }
    }
}
