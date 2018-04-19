using Freescape.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Freescape.Web.Data
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<Entities.Attributes> Attributes { get; set; }
        public virtual DbSet<AuthorizedDms> AuthorizedDms { get; set; }
        public virtual DbSet<BaseItemTypes> BaseItemTypes { get; set; }
        public virtual DbSet<BuildPrivacyDomain> BuildPrivacyDomain { get; set; }
        public virtual DbSet<ChatChannelsDomain> ChatChannelsDomain { get; set; }
        public virtual DbSet<ChatLog> ChatLog { get; set; }
        public virtual DbSet<ClientLogEvents> ClientLogEvents { get; set; }
        public virtual DbSet<ClientLogEventTypesDomain> ClientLogEventTypesDomain { get; set; }
        public virtual DbSet<ConstructionSiteComponents> ConstructionSiteComponents { get; set; }
        public virtual DbSet<ConstructionSites> ConstructionSites { get; set; }
        public virtual DbSet<CooldownCategories> CooldownCategories { get; set; }
        public virtual DbSet<CraftBlueprintCategories> CraftBlueprintCategories { get; set; }
        public virtual DbSet<CraftBlueprintComponents> CraftBlueprintComponents { get; set; }
        public virtual DbSet<CraftBlueprints> CraftBlueprints { get; set; }
        public virtual DbSet<CraftDevices> CraftDevices { get; set; }
        public virtual DbSet<CustomEffects> CustomEffects { get; set; }
        public virtual DbSet<DmroleDomain> DmroleDomain { get; set; }
        public virtual DbSet<Downloads> Downloads { get; set; }
        public virtual DbSet<FameRegions> FameRegions { get; set; }
        public virtual DbSet<GrowingPlants> GrowingPlants { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ItemTypes> ItemTypes { get; set; }
        public virtual DbSet<KeyItemCategories> KeyItemCategories { get; set; }
        public virtual DbSet<KeyItems> KeyItems { get; set; }
        public virtual DbSet<LootTableItems> LootTableItems { get; set; }
        public virtual DbSet<LootTables> LootTables { get; set; }
        public virtual DbSet<Npcgroups> Npcgroups { get; set; }
        public virtual DbSet<Pccooldowns> Pccooldowns { get; set; }
        public virtual DbSet<PccorpseItems> PccorpseItems { get; set; }
        public virtual DbSet<Pccorpses> Pccorpses { get; set; }
        public virtual DbSet<PccustomEffects> PccustomEffects { get; set; }
        public virtual DbSet<PckeyItems> PckeyItems { get; set; }
        public virtual DbSet<PcmapPins> PcmapPins { get; set; }
        public virtual DbSet<PcmigrationItems> PcmigrationItems { get; set; }
        public virtual DbSet<Pcmigrations> Pcmigrations { get; set; }
        public virtual DbSet<Pcoutfits> Pcoutfits { get; set; }
        public virtual DbSet<PcoverflowItems> PcoverflowItems { get; set; }
        public virtual DbSet<Pcperks> Pcperks { get; set; }
        public virtual DbSet<PcquestKillTargetProgress> PcquestKillTargetProgress { get; set; }
        public virtual DbSet<PcquestStatus> PcquestStatus { get; set; }
        public virtual DbSet<PcregionalFame> PcregionalFame { get; set; }
        public virtual DbSet<PcsearchSiteItems> PcsearchSiteItems { get; set; }
        public virtual DbSet<PcsearchSites> PcsearchSites { get; set; }
        public virtual DbSet<Pcskills> Pcskills { get; set; }
        public virtual DbSet<PcterritoryFlags> PcterritoryFlags { get; set; }
        public virtual DbSet<PcterritoryFlagsPermissions> PcterritoryFlagsPermissions { get; set; }
        public virtual DbSet<PcterritoryFlagsStructures> PcterritoryFlagsStructures { get; set; }
        public virtual DbSet<PcterritoryFlagsStructuresItems> PcterritoryFlagsStructuresItems { get; set; }
        public virtual DbSet<PerkCategories> PerkCategories { get; set; }
        public virtual DbSet<PerkExecutionTypes> PerkExecutionTypes { get; set; }
        public virtual DbSet<PerkLevels> PerkLevels { get; set; }
        public virtual DbSet<PerkLevelSkillRequirements> PerkLevelSkillRequirements { get; set; }
        public virtual DbSet<Perks> Perks { get; set; }
        public virtual DbSet<Plants> Plants { get; set; }
        public virtual DbSet<PlayerCharacters> PlayerCharacters { get; set; }
        public virtual DbSet<QuestKillTargetList> QuestKillTargetList { get; set; }
        public virtual DbSet<QuestPrerequisites> QuestPrerequisites { get; set; }
        public virtual DbSet<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public virtual DbSet<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public virtual DbSet<QuestRewardItems> QuestRewardItems { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<QuestStates> QuestStates { get; set; }
        public virtual DbSet<QuestTypeDomain> QuestTypeDomain { get; set; }
        public virtual DbSet<ServerConfiguration> ServerConfiguration { get; set; }
        public virtual DbSet<SkillCategories> SkillCategories { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillXprequirement> SkillXprequirement { get; set; }
        public virtual DbSet<StorageContainers> StorageContainers { get; set; }
        public virtual DbSet<StorageItems> StorageItems { get; set; }
        public virtual DbSet<StructureBlueprints> StructureBlueprints { get; set; }
        public virtual DbSet<StructureCategories> StructureCategories { get; set; }
        public virtual DbSet<StructureComponents> StructureComponents { get; set; }
        public virtual DbSet<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
        public virtual DbSet<TerritoryFlagPermissions> TerritoryFlagPermissions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Attributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeId)
                    .HasColumnName("AttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nwnvalue)
                    .HasColumnName("NWNValue")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AuthorizedDms>(entity =>
            {
                entity.HasKey(e => e.AuthorizedDmid);

                entity.ToTable("AuthorizedDMs");

                entity.Property(e => e.AuthorizedDmid).HasColumnName("AuthorizedDMID");

                entity.Property(e => e.Cdkey)
                    .IsRequired()
                    .HasColumnName("CDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.Dmrole).HasColumnName("DMRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BaseItemTypes>(entity =>
            {
                entity.HasKey(e => e.BaseItemTypeId);

                entity.Property(e => e.BaseItemTypeId)
                    .HasColumnName("BaseItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BuildPrivacyDomain>(entity =>
            {
                entity.HasKey(e => e.BuildPrivacyTypeId);

                entity.Property(e => e.BuildPrivacyTypeId)
                    .HasColumnName("BuildPrivacyTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<ChatChannelsDomain>(entity =>
            {
                entity.HasKey(e => e.ChatChannelId);

                entity.Property(e => e.ChatChannelId)
                    .HasColumnName("ChatChannelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ChatLog>(entity =>
            {
                entity.Property(e => e.ChatLogId).HasColumnName("ChatLogID");

                entity.Property(e => e.ChatChannelId).HasColumnName("ChatChannelID");

                entity.Property(e => e.DateSent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiverAccountName).HasMaxLength(1024);

                entity.Property(e => e.ReceiverCdkey)
                    .HasColumnName("ReceiverCDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiverDmname)
                    .HasColumnName("ReceiverDMName")
                    .HasMaxLength(60);

                entity.Property(e => e.ReceiverPlayerId)
                    .HasColumnName("ReceiverPlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SenderAccountName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderCdkey)
                    .IsRequired()
                    .HasColumnName("SenderCDKey")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderDmname)
                    .HasColumnName("SenderDMName")
                    .HasMaxLength(60);

                entity.Property(e => e.SenderPlayerId)
                    .HasColumnName("SenderPlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.ChatChannel)
                    .WithMany(p => p.ChatLog)
                    .HasForeignKey(d => d.ChatChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ChatLog_ChatChannelID");

                entity.HasOne(d => d.ReceiverPlayer)
                    .WithMany(p => p.ChatLogReceiverPlayer)
                    .HasForeignKey(d => d.ReceiverPlayerId)
                    .HasConstraintName("fk_ChatLog_ReceiverPlayerID");

                entity.HasOne(d => d.SenderPlayer)
                    .WithMany(p => p.ChatLogSenderPlayer)
                    .HasForeignKey(d => d.SenderPlayerId)
                    .HasConstraintName("fk_ChatLog_SenderPlayerID");
            });

            modelBuilder.Entity<ClientLogEvents>(entity =>
            {
                entity.HasKey(e => e.ClientLogEventId);

                entity.Property(e => e.ClientLogEventId).HasColumnName("ClientLogEventID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.Cdkey)
                    .IsRequired()
                    .HasColumnName("CDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientLogEventTypeId).HasColumnName("ClientLogEventTypeID");

                entity.Property(e => e.DateOfEvent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.ClientLogEventType)
                    .WithMany(p => p.ClientLogEvents)
                    .HasForeignKey(d => d.ClientLogEventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLogEvents_ClientLogEventTypeID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ClientLogEvents)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_ClientLogEvents_PlayerID");
            });

            modelBuilder.Entity<ClientLogEventTypesDomain>(entity =>
            {
                entity.HasKey(e => e.ClientLogEventTypeId);

                entity.Property(e => e.ClientLogEventTypeId)
                    .HasColumnName("ClientLogEventTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ConstructionSiteComponents>(entity =>
            {
                entity.HasKey(e => e.ConstructionSiteComponentId);

                entity.Property(e => e.ConstructionSiteComponentId).HasColumnName("ConstructionSiteComponentID");

                entity.Property(e => e.ConstructionSiteId).HasColumnName("ConstructionSiteID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.StructureComponentId).HasColumnName("StructureComponentID");

                entity.HasOne(d => d.ConstructionSite)
                    .WithMany(p => p.ConstructionSiteComponents)
                    .HasForeignKey(d => d.ConstructionSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConstructionSiteComponents_ConstructionSiteID");

                entity.HasOne(d => d.StructureComponent)
                    .WithMany(p => p.ConstructionSiteComponents)
                    .HasForeignKey(d => d.StructureComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConstructionSiteComponents_StructureComponentID");
            });

            modelBuilder.Entity<ConstructionSites>(entity =>
            {
                entity.HasKey(e => e.ConstructionSiteId);

                entity.Property(e => e.ConstructionSiteId).HasColumnName("ConstructionSiteID");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.PcterritoryFlag)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .HasConstraintName("fk_ConstructionSites_PCTerritoryFlagID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ConstructionSites_PlayerID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ConstructionSites_StructureBlueprintID");
            });

            modelBuilder.Entity<CooldownCategories>(entity =>
            {
                entity.HasKey(e => e.CooldownCategoryId);

                entity.Property(e => e.CooldownCategoryId)
                    .HasColumnName("CooldownCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCooldownTime).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CraftBlueprintCategories>(entity =>
            {
                entity.HasKey(e => e.CraftBlueprintCategoryId);

                entity.Property(e => e.CraftBlueprintCategoryId)
                    .HasColumnName("CraftBlueprintCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CraftBlueprintComponents>(entity =>
            {
                entity.HasKey(e => e.CraftComponentId);

                entity.Property(e => e.CraftComponentId).HasColumnName("CraftComponentID");

                entity.Property(e => e.CraftBlueprintId).HasColumnName("CraftBlueprintID");

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.CraftBlueprint)
                    .WithMany(p => p.CraftBlueprintComponents)
                    .HasForeignKey(d => d.CraftBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprintComponents_CraftBlueprintID");
            });

            modelBuilder.Entity<CraftBlueprints>(entity =>
            {
                entity.HasKey(e => e.CraftBlueprintId);

                entity.Property(e => e.CraftBlueprintId)
                    .HasColumnName("CraftBlueprintID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CraftCategoryId).HasColumnName("CraftCategoryID");

                entity.Property(e => e.CraftDeviceId).HasColumnName("CraftDeviceID");

                entity.Property(e => e.CraftTierLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.PerkId).HasColumnName("PerkID");

                entity.Property(e => e.RequiredPerkLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.HasOne(d => d.CraftCategory)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.CraftCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_CraftCategoryID");

                entity.HasOne(d => d.CraftDevice)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.CraftDeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CraftBlueprints_CraftDeviceID");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.PerkId)
                    .HasConstraintName("FK_CraftBlueprints_PerkID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CraftBlueprints_SkillID");
            });

            modelBuilder.Entity<CraftDevices>(entity =>
            {
                entity.HasKey(e => e.CraftDeviceId);

                entity.Property(e => e.CraftDeviceId)
                    .HasColumnName("CraftDeviceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomEffects>(entity =>
            {
                entity.HasKey(e => e.CustomEffectId);

                entity.Property(e => e.CustomEffectId)
                    .HasColumnName("CustomEffectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContinueMessage)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.IconId).HasColumnName("IconID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ScriptHandler)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StartMessage)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.WornOffMessage)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<DmroleDomain>(entity =>
            {
                entity.ToTable("DMRoleDomain");

                entity.Property(e => e.DmroleDomainId)
                    .HasColumnName("DMRoleDomainID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Downloads>(entity =>
            {
                entity.HasKey(e => e.DownloadId);

                entity.Property(e => e.DownloadId)
                    .HasColumnName("DownloadID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FameRegions>(entity =>
            {
                entity.HasKey(e => e.FameRegionId);

                entity.Property(e => e.FameRegionId)
                    .HasColumnName("FameRegionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GrowingPlants>(entity =>
            {
                entity.HasKey(e => e.GrowingPlantId);

                entity.Property(e => e.GrowingPlantId).HasColumnName("GrowingPlantID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationOrientation)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationX)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationY)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationZ)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LongevityBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.RemainingTicks).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalTicks).HasDefaultValueSql("((0))");

                entity.Property(e => e.WaterStatus).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.GrowingPlants)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowingPlants_PlantID");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.Resref);

                entity.Property(e => e.Resref)
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AssociatedSkillId)
                    .HasColumnName("AssociatedSkillID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CastingSpeed).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusArmorsmith).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusCooking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusMetalworking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusWeaponsmith).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusWoodworking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftTierLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.DurabilityPoints).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hpbonus)
                    .HasColumnName("HPBonus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemTypeId)
                    .HasColumnName("ItemTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoggingBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManaBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.MiningBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AssociatedSkill)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.AssociatedSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_SkillID");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_ItemType");
            });

            modelBuilder.Entity<ItemTypes>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.Property(e => e.ItemTypeId)
                    .HasColumnName("ItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KeyItemCategories>(entity =>
            {
                entity.HasKey(e => e.KeyItemCategoryId);

                entity.Property(e => e.KeyItemCategoryId)
                    .HasColumnName("KeyItemCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<KeyItems>(entity =>
            {
                entity.HasKey(e => e.KeyItemId);

                entity.Property(e => e.KeyItemId)
                    .HasColumnName("KeyItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KeyItemCategoryId).HasColumnName("KeyItemCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.KeyItemCategory)
                    .WithMany(p => p.KeyItems)
                    .HasForeignKey(d => d.KeyItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KeyItems_KeyItemCategoryID");
            });

            modelBuilder.Entity<LootTableItems>(entity =>
            {
                entity.HasKey(e => e.LootTableItemId);

                entity.Property(e => e.LootTableItemId).HasColumnName("LootTableItemID");

                entity.Property(e => e.LootTableId).HasColumnName("LootTableID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.LootTable)
                    .WithMany(p => p.LootTableItems)
                    .HasForeignKey(d => d.LootTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LootTableItems_LootTableID");
            });

            modelBuilder.Entity<LootTables>(entity =>
            {
                entity.HasKey(e => e.LootTableId);

                entity.Property(e => e.LootTableId)
                    .HasColumnName("LootTableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Npcgroups>(entity =>
            {
                entity.HasKey(e => e.NpcgroupId);

                entity.ToTable("NPCGroups");

                entity.Property(e => e.NpcgroupId)
                    .HasColumnName("NPCGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Pccooldowns>(entity =>
            {
                entity.HasKey(e => e.PccooldownId);

                entity.ToTable("PCCooldowns");

                entity.Property(e => e.PccooldownId).HasColumnName("PCCooldownID");

                entity.Property(e => e.CooldownCategoryId).HasColumnName("CooldownCategoryID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CooldownCategory)
                    .WithMany(p => p.Pccooldowns)
                    .HasForeignKey(d => d.CooldownCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCooldowns_CooldownCategoryID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pccooldowns)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCooldowns_PlayerID");
            });

            modelBuilder.Entity<PccorpseItems>(entity =>
            {
                entity.HasKey(e => e.PccorpseItemId);

                entity.ToTable("PCCorpseItems");

                entity.Property(e => e.PccorpseItemId).HasColumnName("PCCorpseItemID");

                entity.Property(e => e.NwitemObject)
                    .IsRequired()
                    .HasColumnName("NWItemObject");

                entity.Property(e => e.PccorpseId).HasColumnName("PCCorpseID");

                entity.HasOne(d => d.Pccorpse)
                    .WithMany(p => p.PccorpseItems)
                    .HasForeignKey(d => d.PccorpseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCorpseItems_PCCorpseID");
            });

            modelBuilder.Entity<Pccorpses>(entity =>
            {
                entity.HasKey(e => e.PccorpseId);

                entity.ToTable("PCCorpses");

                entity.Property(e => e.PccorpseId).HasColumnName("PCCorpseID");

                entity.Property(e => e.AreaTag).HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PccustomEffects>(entity =>
            {
                entity.HasKey(e => e.PccustomEffectId);

                entity.ToTable("PCCustomEffects");

                entity.Property(e => e.PccustomEffectId).HasColumnName("PCCustomEffectID");

                entity.Property(e => e.CustomEffectId).HasColumnName("CustomEffectID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CustomEffect)
                    .WithMany(p => p.PccustomEffects)
                    .HasForeignKey(d => d.CustomEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffects_CustomEffectID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PccustomEffects)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffects_PlayerID");
            });

            modelBuilder.Entity<PckeyItems>(entity =>
            {
                entity.HasKey(e => e.PckeyItemId);

                entity.ToTable("PCKeyItems");

                entity.Property(e => e.PckeyItemId).HasColumnName("PCKeyItemID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.KeyItemId).HasColumnName("KeyItemID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.PckeyItems)
                    .HasForeignKey(d => d.KeyItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItems_KeyItemID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PckeyItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItems_PlayerID");
            });

            modelBuilder.Entity<PcmapPins>(entity =>
            {
                entity.HasKey(e => e.PcmapPinId);

                entity.ToTable("PCMapPins");

                entity.Property(e => e.PcmapPinId).HasColumnName("PCMapPinID");

                entity.Property(e => e.AreaTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcmapPins)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCMapPins_PlayerID");
            });

            modelBuilder.Entity<PcmigrationItems>(entity =>
            {
                entity.HasKey(e => e.PcmigrationItemId);

                entity.ToTable("PCMigrationItems");

                entity.Property(e => e.PcmigrationItemId)
                    .HasColumnName("PCMigrationItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseItemTypeId).HasColumnName("BaseItemTypeID");

                entity.Property(e => e.CurrentResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.NewResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.PcmigrationId).HasColumnName("PCMigrationID");

                entity.HasOne(d => d.BaseItemType)
                    .WithMany(p => p.PcmigrationItems)
                    .HasForeignKey(d => d.BaseItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_BaseItemTypeID");

                entity.HasOne(d => d.Pcmigration)
                    .WithMany(p => p.PcmigrationItems)
                    .HasForeignKey(d => d.PcmigrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_PCMigrationID");
            });

            modelBuilder.Entity<Pcmigrations>(entity =>
            {
                entity.HasKey(e => e.PcmigrationId);

                entity.ToTable("PCMigrations");

                entity.Property(e => e.PcmigrationId)
                    .HasColumnName("PCMigrationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Pcoutfits>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("PCOutfits");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Player)
                    .WithOne(p => p.Pcoutfits)
                    .HasForeignKey<Pcoutfits>(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOutfits_PlayerID");
            });

            modelBuilder.Entity<PcoverflowItems>(entity =>
            {
                entity.HasKey(e => e.PcoverflowItemId);

                entity.ToTable("PCOverflowItems");

                entity.Property(e => e.PcoverflowItemId).HasColumnName("PCOverflowItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcoverflowItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOverflowItems_PlayerID");
            });

            modelBuilder.Entity<Pcperks>(entity =>
            {
                entity.HasKey(e => e.PcperkId);

                entity.ToTable("PCPerks");

                entity.Property(e => e.PcperkId).HasColumnName("PCPerkID");

                entity.Property(e => e.AcquiredDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PerkId).HasColumnName("PerkID");

                entity.Property(e => e.PerkLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.Pcperks)
                    .HasForeignKey(d => d.PerkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCPerks_PerkID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pcperks)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCPerks_PlayerID");
            });

            modelBuilder.Entity<PcquestKillTargetProgress>(entity =>
            {
                entity.ToTable("PCQuestKillTargetProgress");

                entity.Property(e => e.PcquestKillTargetProgressId).HasColumnName("PCQuestKillTargetProgressID");

                entity.Property(e => e.NpcgroupId).HasColumnName("NPCGroupID");

                entity.Property(e => e.PcquestStatusId).HasColumnName("PCQuestStatusID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Npcgroup)
                    .WithMany(p => p.PcquestKillTargetProgress)
                    .HasForeignKey(d => d.NpcgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_NPCGroupID");

                entity.HasOne(d => d.PcquestStatus)
                    .WithMany(p => p.PcquestKillTargetProgress)
                    .HasForeignKey(d => d.PcquestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PCQuestStatusID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcquestKillTargetProgress)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PlayerID");
            });

            modelBuilder.Entity<PcquestStatus>(entity =>
            {
                entity.ToTable("PCQuestStatus");

                entity.Property(e => e.PcquestStatusId).HasColumnName("PCQuestStatusID");

                entity.Property(e => e.CurrentQuestStateId).HasColumnName("CurrentQuestStateID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.SelectedItemRewardId).HasColumnName("SelectedItemRewardID");

                entity.HasOne(d => d.CurrentQuestState)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.CurrentQuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_CurrentQuestStateID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_PlayerID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_QuestID");

                entity.HasOne(d => d.SelectedItemReward)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.SelectedItemRewardId)
                    .HasConstraintName("FK_PCQuestStatus_SelectedRewardID");
            });

            modelBuilder.Entity<PcregionalFame>(entity =>
            {
                entity.ToTable("PCRegionalFame");

                entity.Property(e => e.PcregionalFameId).HasColumnName("PCRegionalFameID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FameRegionId).HasColumnName("FameRegionID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.PcregionalFame)
                    .HasForeignKey(d => d.FameRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCRegionalFame_FameRegionID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcregionalFame)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCRegionalFame_PlayerID");
            });

            modelBuilder.Entity<PcsearchSiteItems>(entity =>
            {
                entity.HasKey(e => e.PcsearchSiteItemId);

                entity.ToTable("PCSearchSiteItems");

                entity.Property(e => e.PcsearchSiteItemId).HasColumnName("PCSearchSiteItemID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchItem).IsRequired();

                entity.Property(e => e.SearchSiteId).HasColumnName("SearchSiteID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcsearchSiteItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSiteItems_PlayerID");
            });

            modelBuilder.Entity<PcsearchSites>(entity =>
            {
                entity.HasKey(e => e.PcsearchSiteId);

                entity.ToTable("PCSearchSites");

                entity.Property(e => e.PcsearchSiteId).HasColumnName("PCSearchSiteID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchSiteId).HasColumnName("SearchSiteID");

                entity.Property(e => e.UnlockDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcsearchSites)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSites_PlayerID");
            });

            modelBuilder.Entity<Pcskills>(entity =>
            {
                entity.HasKey(e => e.PcskillId);

                entity.ToTable("PCSkills");

                entity.Property(e => e.PcskillId).HasColumnName("PCSkillID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.Rank).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Xp)
                    .HasColumnName("XP")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pcskills)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCSkills_PlayerID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Pcskills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCSkills_SkillID");
            });

            modelBuilder.Entity<PcterritoryFlags>(entity =>
            {
                entity.HasKey(e => e.PcterritoryFlagId);

                entity.ToTable("PCTerritoryFlags");

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.BuildPrivacySettingId)
                    .HasColumnName("BuildPrivacySettingID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.BuildPrivacySetting)
                    .WithMany(p => p.PcterritoryFlags)
                    .HasForeignKey(d => d.BuildPrivacySettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlags_BuildPrivacySettingID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcterritoryFlags)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlags_PlayerID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.PcterritoryFlags)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlags_StructureBlueprintID");
            });

            modelBuilder.Entity<PcterritoryFlagsPermissions>(entity =>
            {
                entity.HasKey(e => e.PcterritoryFlagPermissionId);

                entity.ToTable("PCTerritoryFlagsPermissions");

                entity.Property(e => e.PcterritoryFlagPermissionId).HasColumnName("PCTerritoryFlagPermissionID");

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.TerritoryFlagPermissionId).HasColumnName("TerritoryFlagPermissionID");

                entity.HasOne(d => d.PcterritoryFlag)
                    .WithMany(p => p.PcterritoryFlagsPermissions)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_PCTerritoryFlagID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcterritoryFlagsPermissions)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_PlayerID");

                entity.HasOne(d => d.TerritoryFlagPermission)
                    .WithMany(p => p.PcterritoryFlagsPermissions)
                    .HasForeignKey(d => d.TerritoryFlagPermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_TerritoryFlagPermissionID");
            });

            modelBuilder.Entity<PcterritoryFlagsStructures>(entity =>
            {
                entity.HasKey(e => e.PcterritoryFlagStructureId);

                entity.ToTable("PCTerritoryFlagsStructures");

                entity.Property(e => e.PcterritoryFlagStructureId).HasColumnName("PCTerritoryFlagStructureID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CustomName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.PcterritoryFlag)
                    .WithMany(p => p.PcterritoryFlagsStructures)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructures_PCTerritoryFlagID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.PcterritoryFlagsStructures)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructures_StructureBlueprintID");
            });

            modelBuilder.Entity<PcterritoryFlagsStructuresItems>(entity =>
            {
                entity.HasKey(e => e.PcstructureItemId);

                entity.ToTable("PCTerritoryFlagsStructuresItems");

                entity.Property(e => e.PcstructureItemId).HasColumnName("PCStructureItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PcstructureId).HasColumnName("PCStructureID");

                entity.HasOne(d => d.Pcstructure)
                    .WithMany(p => p.PcterritoryFlagsStructuresItems)
                    .HasForeignKey(d => d.PcstructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructuresItems_PCStructureID");
            });

            modelBuilder.Entity<PerkCategories>(entity =>
            {
                entity.HasKey(e => e.PerkCategoryId);

                entity.Property(e => e.PerkCategoryId)
                    .HasColumnName("PerkCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sequence).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PerkExecutionTypes>(entity =>
            {
                entity.HasKey(e => e.PerkExecutionTypeId);

                entity.Property(e => e.PerkExecutionTypeId)
                    .HasColumnName("PerkExecutionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PerkLevels>(entity =>
            {
                entity.HasKey(e => e.PerkLevelId);

                entity.HasIndex(e => new { e.PerkId, e.Level })
                    .HasName("uq_PerkLevels_PerkIDLevel")
                    .IsUnique();

                entity.Property(e => e.PerkLevelId).HasColumnName("PerkLevelID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.PerkId).HasColumnName("PerkID");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PerkLevels)
                    .HasForeignKey(d => d.PerkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevels_PerkID");
            });

            modelBuilder.Entity<PerkLevelSkillRequirements>(entity =>
            {
                entity.HasKey(e => e.PerkLevelSkillRequirementId);

                entity.Property(e => e.PerkLevelSkillRequirementId).HasColumnName("PerkLevelSkillRequirementID");

                entity.Property(e => e.PerkLevelId).HasColumnName("PerkLevelID");

                entity.Property(e => e.RequiredRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.HasOne(d => d.PerkLevel)
                    .WithMany(p => p.PerkLevelSkillRequirements)
                    .HasForeignKey(d => d.PerkLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelSkillRequirements_PerkLevelID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PerkLevelSkillRequirements)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelSkillRequirements_SkillID");
            });

            modelBuilder.Entity<Perks>(entity =>
            {
                entity.HasKey(e => e.PerkId);

                entity.Property(e => e.PerkId)
                    .HasColumnName("PerkID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCastingTime).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.BaseManaCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.CooldownCategoryId).HasColumnName("CooldownCategoryID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExecutionTypeId)
                    .HasColumnName("ExecutionTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeatId)
                    .HasColumnName("FeatID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemResref).HasMaxLength(16);

                entity.Property(e => e.JavaScriptName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerkCategoryId).HasColumnName("PerkCategoryID");

                entity.HasOne(d => d.CooldownCategory)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.CooldownCategoryId)
                    .HasConstraintName("fk_Perks_CooldownCategoryID");

                entity.HasOne(d => d.ExecutionType)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.ExecutionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perks_ExecutionTypeID");

                entity.HasOne(d => d.PerkCategory)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.PerkCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perks_PerkCategoryID");
            });

            modelBuilder.Entity<Plants>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseTicks).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WaterTicks).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PlayerCharacters>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Chabase)
                    .HasColumnName("CHABase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Conbase)
                    .HasColumnName("CONBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTimestamp)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CurrentMana).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentManaTick).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateLastForcedSpreset).HasColumnName("DateLastForcedSPReset");

                entity.Property(e => e.DateSanctuaryEnds).HasDefaultValueSql("(dateadd(hour,(72),getutcdate()))");

                entity.Property(e => e.Dexbase)
                    .HasColumnName("DEXBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayHelmet).HasDefaultValueSql("((1))");

                entity.Property(e => e.HpregenerationAmount).HasColumnName("HPRegenerationAmount");

                entity.Property(e => e.Intbase)
                    .HasColumnName("INTBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MaxMana).HasDefaultValueSql("((0))");

                entity.Property(e => e.NextResetTokenReceiveDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.NextSpresetDate)
                    .HasColumnName("NextSPResetDate")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NumberOfSpresets).HasColumnName("NumberOfSPResets");

                entity.Property(e => e.RespawnAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RespawnLocationOrientation).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationX).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationY).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationZ).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RevivalStoneCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Strbase)
                    .HasColumnName("STRBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSpacquired)
                    .HasColumnName("TotalSPAcquired")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnallocatedSp).HasColumnName("UnallocatedSP");

                entity.Property(e => e.Wisbase)
                    .HasColumnName("WISBase")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QuestKillTargetList>(entity =>
            {
                entity.Property(e => e.QuestKillTargetListId).HasColumnName("QuestKillTargetListID");

                entity.Property(e => e.NpcgroupId).HasColumnName("NPCGroupID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.HasOne(d => d.Npcgroup)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.NpcgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_NPCGroupID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.QuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_QuestStateID");
            });

            modelBuilder.Entity<QuestPrerequisites>(entity =>
            {
                entity.HasKey(e => e.QuestPrerequisiteId);

                entity.Property(e => e.QuestPrerequisiteId).HasColumnName("QuestPrerequisiteID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.RequiredQuestId).HasColumnName("RequiredQuestID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestPrerequisitesQuest)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisites_QuestID");

                entity.HasOne(d => d.RequiredQuest)
                    .WithMany(p => p.QuestPrerequisitesRequiredQuest)
                    .HasForeignKey(d => d.RequiredQuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisites_RequiredQuestID");
            });

            modelBuilder.Entity<QuestRequiredItemList>(entity =>
            {
                entity.Property(e => e.QuestRequiredItemListId).HasColumnName("QuestRequiredItemListID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredItemList)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItemList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredItemList)
                    .HasForeignKey(d => d.QuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItemList");
            });

            modelBuilder.Entity<QuestRequiredKeyItemList>(entity =>
            {
                entity.HasKey(e => e.QuestRequiredKeyItemId);

                entity.Property(e => e.QuestRequiredKeyItemId).HasColumnName("QuestRequiredKeyItemID");

                entity.Property(e => e.KeyItemId).HasColumnName("KeyItemID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.KeyItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList_KeyItemID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.QuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList");
            });

            modelBuilder.Entity<QuestRewardItems>(entity =>
            {
                entity.HasKey(e => e.QuestRewardItemId);

                entity.Property(e => e.QuestRewardItemId).HasColumnName("QuestRewardItemID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRewardItems)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRewards_QuestID");
            });

            modelBuilder.Entity<Quests>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.FameRegionId).HasColumnName("FameRegionID");

                entity.Property(e => e.JournalTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.MapNoteTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RewardKeyItemId).HasColumnName("RewardKeyItemID");

                entity.Property(e => e.RewardXp).HasColumnName("RewardXP");

                entity.Property(e => e.StartKeyItemId).HasColumnName("StartKeyItemID");

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.Quests)
                    .HasForeignKey(d => d.FameRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quests_FameRegionID");

                entity.HasOne(d => d.RewardKeyItem)
                    .WithMany(p => p.QuestsRewardKeyItem)
                    .HasForeignKey(d => d.RewardKeyItemId)
                    .HasConstraintName("FK_Quests_RewardKeyItemID");

                entity.HasOne(d => d.StartKeyItem)
                    .WithMany(p => p.QuestsStartKeyItem)
                    .HasForeignKey(d => d.StartKeyItemId)
                    .HasConstraintName("FK_Quests_TemporaryKeyItemID");
            });

            modelBuilder.Entity<QuestStates>(entity =>
            {
                entity.HasKey(e => e.QuestStateId);

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.Property(e => e.JournalStateId).HasColumnName("JournalStateID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestTypeId).HasColumnName("QuestTypeID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestID");

                entity.HasOne(d => d.QuestType)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestTypeID");
            });

            modelBuilder.Entity<QuestTypeDomain>(entity =>
            {
                entity.HasKey(e => e.QuestTypeId);

                entity.Property(e => e.QuestTypeId)
                    .HasColumnName("QuestTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ServerConfiguration>(entity =>
            {
                entity.Property(e => e.ServerConfigurationId)
                    .HasColumnName("ServerConfigurationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageOfTheDay)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SkillCategories>(entity =>
            {
                entity.HasKey(e => e.SkillCategoryId);

                entity.Property(e => e.SkillCategoryId)
                    .HasColumnName("SkillCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sequence).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.Property(e => e.SkillId)
                    .HasColumnName("SkillID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Primary).HasDefaultValueSql("('')");

                entity.Property(e => e.Secondary).HasDefaultValueSql("('')");

                entity.Property(e => e.SkillCategoryId).HasColumnName("SkillCategoryID");

                entity.Property(e => e.Tertiary).HasDefaultValueSql("('')");

                entity.HasOne(d => d.PrimaryNavigation)
                    .WithMany(p => p.SkillsPrimaryNavigation)
                    .HasForeignKey(d => d.Primary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Primary");

                entity.HasOne(d => d.SecondaryNavigation)
                    .WithMany(p => p.SkillsSecondaryNavigation)
                    .HasForeignKey(d => d.Secondary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Secondary");

                entity.HasOne(d => d.SkillCategory)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.SkillCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_SkillCategoryID");

                entity.HasOne(d => d.TertiaryNavigation)
                    .WithMany(p => p.SkillsTertiaryNavigation)
                    .HasForeignKey(d => d.Tertiary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Tertiary");
            });

            modelBuilder.Entity<SkillXprequirement>(entity =>
            {
                entity.ToTable("SkillXPRequirement");

                entity.Property(e => e.SkillXprequirementId).HasColumnName("SkillXPRequirementID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Xp).HasColumnName("XP");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkillXprequirement)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SkillXPRequirement_SkillID");
            });

            modelBuilder.Entity<StorageContainers>(entity =>
            {
                entity.HasKey(e => e.StorageContainerId);

                entity.Property(e => e.StorageContainerId)
                    .HasColumnName("StorageContainerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.AreaTag)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<StorageItems>(entity =>
            {
                entity.HasKey(e => e.StorageItemId);

                entity.Property(e => e.StorageItemId).HasColumnName("StorageItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StorageContainerId).HasColumnName("StorageContainerID");

                entity.HasOne(d => d.StorageContainer)
                    .WithMany(p => p.StorageItems)
                    .HasForeignKey(d => d.StorageContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StorageItems_StorageContainerID");
            });

            modelBuilder.Entity<StructureBlueprints>(entity =>
            {
                entity.HasKey(e => e.StructureBlueprintId);

                entity.Property(e => e.StructureBlueprintId)
                    .HasColumnName("StructureBlueprintID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CraftTierLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GivesSkillXp).HasColumnName("GivesSkillXP");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PerkId).HasColumnName("PerkID");

                entity.Property(e => e.RequiredPerkLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SpecialCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StructureCategoryId).HasColumnName("StructureCategoryID");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.StructureBlueprints)
                    .HasForeignKey(d => d.PerkId)
                    .HasConstraintName("FK_StructureBlueprints_PerkID");

                entity.HasOne(d => d.StructureCategory)
                    .WithMany(p => p.StructureBlueprints)
                    .HasForeignKey(d => d.StructureCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StructureBlueprints_StructureCategoryID");
            });

            modelBuilder.Entity<StructureCategories>(entity =>
            {
                entity.HasKey(e => e.StructureCategoryId);

                entity.Property(e => e.StructureCategoryId).HasColumnName("StructureCategoryID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<StructureComponents>(entity =>
            {
                entity.HasKey(e => e.StructureComponentId);

                entity.Property(e => e.StructureComponentId).HasColumnName("StructureComponentID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.StructureComponents)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructureComponents_StructureBlueprintID");
            });

            modelBuilder.Entity<StructureQuickBuildAudit>(entity =>
            {
                entity.HasKey(e => e.StructureQuickBuildId);

                entity.Property(e => e.StructureQuickBuildId).HasColumnName("StructureQuickBuildID");

                entity.Property(e => e.DateBuilt).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Dmname)
                    .IsRequired()
                    .HasColumnName("DMName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PcterritoryFlagStructureId).HasColumnName("PCTerritoryFlagStructureID");

                entity.HasOne(d => d.PcterritoryFlag)
                    .WithMany(p => p.StructureQuickBuildAudit)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .HasConstraintName("FK_StructureQuickBuildAudit_PCTerritoryFlagID");

                entity.HasOne(d => d.PcterritoryFlagStructure)
                    .WithMany(p => p.StructureQuickBuildAudit)
                    .HasForeignKey(d => d.PcterritoryFlagStructureId)
                    .HasConstraintName("FK_StructureQuickBuildAudit_PCTerritoryFlagStructureID");
            });

            modelBuilder.Entity<TerritoryFlagPermissions>(entity =>
            {
                entity.HasKey(e => e.TerritoryFlagPermissionId);

                entity.Property(e => e.TerritoryFlagPermissionId)
                    .HasColumnName("TerritoryFlagPermissionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AvatarHash).IsRequired();

                entity.Property(e => e.DateRegistered).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DiscordUserId)
                    .IsRequired()
                    .HasColumnName("DiscordUserID");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_RoleID");
            });
        }
    }
}
