namespace EnterpriseRpg.Engine.Models;

public enum GearSlot { Melee, Ranged, Armor, Artifact1, Artifact2, Artifact3 }

public enum Rarity
{
    Common = 0,
    Uncommon = 1,
    Rare = 2,
    Epic = 3,
    Legendary = 4,
    Mythic = 5
}

public enum BiomeKind
{
    Shore,
    Forest,
    Farmland,
    Swamp,
    Mines,
    Forge,
    Temple,
    Fortress,
    Spire,
    Archive,
    Crypt,
    Canyon,
    Glacier,
    Jungle,
    Ruins,
    Infinity
}

public enum MobFamily
{
    Undead,
    Cultist,
    Slime,
    Construct,
    Shadow,
    Beast,
    Boss,
    Elemental,
    Insect,
    Pirate
}

public enum ArtifactKind
{
    Damage,
    Heal,
    Shield,
    Utility,
    Summon,
    Buff,
    Debuff,
    Mobility
}

public enum EnchantmentId
{
    KeenEdge,
    EmberBite,
    SaltEdge,
    Piercing,
    FatalPrecision,
    Leeching,
    Thorns,
    SwiftStrike,
    HeavyBlow,
    Radiant,
    Frostbite,
    ChainLightning,
    SoulHarvest,
    Guarding,
    MultiShot
}

public enum MissionId
{
    TidewrackShore = 1,
    WhisperpineHollow = 2,
    HarvestMoonFields = 3,
    Mirefen = 4,
    CopperveinDepths = 5,
    CinderFoundry = 6,
    SunkenSanctum = 7,
    HighcourtBastion = 8,
    ObsidianSpire = 9,
    FinalArchive = 10,
    BoneCrypts = 11,
    SunscorchCanyon = 12,
    FrostveinGlacier = 13,
    VenomwoodJungle = 14,
    ShatteredRuins = 15,
    InfinitySpire = 99
}

public enum RoomType
{
    Combat,
    Elite,
    Treasure,
    Merchant,
    Shrine,
    MiniBoss,
    Boss,
    Secret
}

public enum StatusEffect
{
    None,
    Burning,
    Frozen,
    Poisoned,
    Stunned,
    Shielded,
    Empowered,
    Weakened
}
