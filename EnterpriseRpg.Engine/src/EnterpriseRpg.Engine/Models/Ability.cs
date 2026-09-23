namespace EnterpriseRpg.Engine.Models;

public enum AbilityId
{
    Whirlwind, PowerShot, ShieldBash, GroundSlam, ShadowStep, ChainPull, ArcSlash, Volley,
    EmberBurst, SoulDrain, TimeSlow, GuardianWall, MeteorCall,
    PhaseShift, SoulStorm, CrownShatter,
    InfinitySlash, AbsoluteZero, WorldBreaker, SovereignJudgment, AllPowersUnleashed
}

public sealed class AbilityDef
{
    public required AbilityId Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
    public int CooldownTurns { get; init; } = 4;
    public int Power { get; init; } = 30;
    public AbilityTarget Target { get; init; } = AbilityTarget.Enemy;
    public StatusEffect ApplyStatus { get; init; } = StatusEffect.None;
    public double StatusChance { get; init; } = 0.0;
    public bool InfinityOnly { get; init; }
    public bool BossOnly { get; init; }
}

public enum AbilityTarget { Self, Enemy, AllEnemies, Area }

public static class AbilityCatalog
{
    public static readonly AbilityDef[] All =
    {
        new() { Id = AbilityId.Whirlwind, Name = "Whirlwind", Description = "Spin attack hitting nearby foes.", Power = 35, CooldownTurns = 3 },
        new() { Id = AbilityId.PowerShot, Name = "Power Shot", Description = "Charged arrow that pierces armor.", Power = 45, CooldownTurns = 4 },
        new() { Id = AbilityId.ShieldBash, Name = "Shield Bash", Description = "Stun an enemy briefly.", Power = 20, CooldownTurns = 3, ApplyStatus = StatusEffect.Stunned, StatusChance = 1.0 },
        new() { Id = AbilityId.GroundSlam, Name = "Ground Slam", Description = "AoE shockwave.", Power = 40, CooldownTurns = 5, Target = AbilityTarget.AllEnemies },
        new() { Id = AbilityId.InfinitySlash, Name = "Infinity Slash", Description = "Blade that cuts dimensions.", Power = 100, CooldownTurns = 5, InfinityOnly = true },
        new() { Id = AbilityId.AbsoluteZero, Name = "Absolute Zero", Description = "Freeze everything.", Power = 80, CooldownTurns = 6, InfinityOnly = true, ApplyStatus = StatusEffect.Frozen, StatusChance = 1.0, Target = AbilityTarget.AllEnemies },
        new() { Id = AbilityId.WorldBreaker, Name = "World Breaker", Description = "Shatter the floor itself.", Power = 150, CooldownTurns = 8, InfinityOnly = true, Target = AbilityTarget.AllEnemies },
        new() { Id = AbilityId.SovereignJudgment, Name = "Sovereign Judgment", Description = "Kael's true power — only on Infinity.", Power = 200, CooldownTurns = 10, InfinityOnly = true, BossOnly = true },
        new() { Id = AbilityId.AllPowersUnleashed, Name = "All Powers Unleashed", Description = "Every ability at once. Infinity final boss only.", Power = 300, CooldownTurns = 12, InfinityOnly = true, BossOnly = true, Target = AbilityTarget.AllEnemies },
    };
    public static AbilityDef? Get(AbilityId id) => All.FirstOrDefault(a => a.Id == id);
    public static IEnumerable<AbilityDef> ForInfinity() => All.Where(a => a.InfinityOnly);
    public static IEnumerable<AbilityDef> ForBoss() => All.Where(a => a.BossOnly);
}
