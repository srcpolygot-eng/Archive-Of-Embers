# Archive of Embers

**Minecraft Dungeons–style** dungeon-action RPG (.NET 8 + Godot 4 3D) with an **Infinity Spire** endgame.

## Campaign

### Act 1 — Freehold (10 missions)
Tidewrack Shore → … → **Final Archive** (Kael the Bound)

### Act 2 — Expanded World (5 missions)
Bone Crypts · Sunscorch Canyon · Frostvein Glacier · Venomwood Jungle · Shattered Ruins

### Act 3 — Infinity Spire
- **50 procedural floors** that grow harder and more void-tainted
- Floor bosses every 10 levels
- **Floor 50:** face **Kael Unbound — All Powers**  
  Only here can the boss use *Sovereign Judgment* and *All Powers Unleashed*  
  Player can earn Infinity-only gear & abilities (Infinity Edge, Infinity Shell, Spire Heart, Infinity Slash, Absolute Zero, World Breaker)

## Systems

| System | Details |
|--------|---------|
| **Biomes** | 16 (incl. Infinity) with unique materials, fog, props |
| **Rooms** | Combat · Elite · Treasure · Merchant · Shrine · MiniBoss · Boss · Secret |
| **Enchantments** | 15 (Keen Edge, Leeching, Frostbite, MultiShot, …) |
| **Abilities** | Weapon / artifact / boss / **Infinity-only** custom powers |
| **Combat** | Crits, status effects, boss phases, thorns, piercing |
| **Gear** | Signature weapons, armor, artifacts + procedural drops |
| **DungeonBuilder** | Multi-room layouts, alcoves, platforms, portals, Infinity finale arena |
| **AnimSystem** | Procedural swing, bob, dash stretch, hit flash, death dissolve, boss aura |

## Projects

| Folder | Role |
|--------|------|
| `EnterpriseRpg.Engine` | Domain: missions, combat, loot, abilities, Infinity |
| `EnterpriseRpg.Game` | Spectre.Console terminal client |
| `ArchiveOfEmbers.Godot` | Godot 4 .NET 3D client |

## Run

```bash
dotnet run --project EnterpriseRpg.Game -c Release
# Godot 4.2+ .NET: open ArchiveOfEmbers.Godot, F5
python3 ArchiveOfEmbers.Godot/tools/generate_glbs.py   # regenerate models
```

Story: clear Freehold, push into the expanded world, then climb the **Infinity Spire** and face Kael with every power unlocked.
