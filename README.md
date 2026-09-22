# Archive of Embers

Original Freehold dungeon-action RPG (.NET 8 + Godot 4 3D).

## Projects

| Folder | Role |
|--------|------|
| `EnterpriseRpg.Engine` | Shared C# domain (missions, combat, loot, **12 signature weapons**) |
| `EnterpriseRpg.Game` | Spectre.Console terminal client |
| `ArchiveOfEmbers.Godot` | Godot 4 .NET 3D client |

## Godot 3D highlights

- **10 biome kits** — full material/fog/prop sets
- **10 boss arenas** — unique layouts per biome
- **CharacterAssembler** — multi-part heroes & enemies (GLB swap-ready)
- **WeaponVisualFactory** — meshes for all signature weapons
- Enemy AI, projectiles, dodge, HUD

```bash
# Terminal
dotnet run --project EnterpriseRpg.Game -c Release

# Godot: open ArchiveOfEmbers.Godot in Godot 4.2+ .NET, press F5
```

Story: clear ten missions, claim Level Keys, defeat **Kael the Bound** and the Crownshard.
