namespace Freescape.Web.Data.Entities
{
    public partial class Items
    {
        public string Resref { get; set; }
        public int Ac { get; set; }
        public int ItemTypeId { get; set; }
        public int RecommendedLevel { get; set; }
        public int LoggingBonus { get; set; }
        public int MiningBonus { get; set; }
        public int CastingSpeed { get; set; }
        public int CraftBonusMetalworking { get; set; }
        public int CraftBonusWeaponsmith { get; set; }
        public int CraftBonusArmorsmith { get; set; }
        public int CraftBonusCooking { get; set; }
        public int DurabilityPoints { get; set; }
        public int AssociatedSkillId { get; set; }
        public int CraftTierLevel { get; set; }
        public int CraftBonusWoodworking { get; set; }
        public int Weight { get; set; }
        public int Hpbonus { get; set; }
        public int ManaBonus { get; set; }

        public Skills AssociatedSkill { get; set; }
        public ItemTypes ItemType { get; set; }
    }
}
