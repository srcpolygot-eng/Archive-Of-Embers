# Getting Started — Archive of Embers

## Repo status

Core systems, project structure, README, Enums, Ability system, and more are on `main`.

**GLB 3D models** are binary and are regenerated locally:

```bash
cd ArchiveOfEmbers.Godot
python3 tools/generate_glbs.py
```

## Full source

If any file is missing after clone, the complete workspace (including all expanded C#, Godot scripts, and GLBs) was built in this session. You can also re-extract from your original zip and overlay the expanded files under `EnterpriseRpg.Engine` and `ArchiveOfEmbers.Godot`.

## Infinity Spire

- MissionId.InfinitySpire = 99
- 50 floors; floor 50 = **Kael Unbound — All Powers**
- Infinity-only abilities: InfinitySlash, AbsoluteZero, WorldBreaker, SovereignJudgment, AllPowersUnleashed

## Run

```bash
dotnet run --project EnterpriseRpg.Game -c Release
# Godot 4.2+ .NET: open ArchiveOfEmbers.Godot, press F5
```
