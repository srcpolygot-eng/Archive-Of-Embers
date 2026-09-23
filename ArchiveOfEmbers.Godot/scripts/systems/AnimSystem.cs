using Godot;

namespace ArchiveOfEmbers.GodotClient.Systems;

/// <summary>
/// Procedural 3D animation helpers — swing, bob, pulse, dash trails, hit flash, death dissolve.
/// </summary>
public static class AnimSystem
{
	public static void SwingWeapon(Node3D? pivot, float t, float duration, bool rightHand = true)
	{
		if (pivot is null || duration <= 0) return;
		var u = Mathf.Clamp(t / duration, 0f, 1f);
		var arc = Mathf.Sin(u * Mathf.Pi);
		var yaw = (rightHand ? -1f : 1f) * Mathf.Lerp(0f, 110f, arc);
		var pitch = Mathf.Lerp(0f, -35f, arc);
		pivot.RotationDegrees = new Vector3(pitch, yaw, arc * 15f);
		if (u >= 1f) pivot.RotationDegrees = Vector3.Zero;
	}

	public static void BobIdle(Node3D? node, float time, float amp = 0.04f, float speed = 2.2f)
	{
		if (node is null) return;
		var y = Mathf.Sin(time * speed) * amp;
		var pos = node.Position;
		node.Position = new Vector3(pos.X, pos.Y + (y - node.GetMeta("bob_last", 0f).AsSingle()), pos.Z);
		node.SetMeta("bob_last", y);
	}

	public static void DashStretch(Node3D? node, float dashT, float duration)
	{
		if (node is null || duration <= 0) return;
		var u = Mathf.Clamp(dashT / duration, 0f, 1f);
		var stretch = 1f + Mathf.Sin(u * Mathf.Pi) * 0.35f;
		node.Scale = new Vector3(1f / stretch, 1f, stretch);
		if (u >= 1f) node.Scale = Vector3.One;
	}

	public static void DeathDissolve(Node3D? node, float progress)
	{
		if (node is null) return;
		var p = Mathf.Clamp(progress, 0f, 1f);
		node.Scale = Vector3.One * (1f - p * 0.8f);
		node.Position += Vector3.Up * p * 0.5f;
	}

	public static void BossEnrageAura(Node3D parent, ref GpuParticles3D? aura, Color color)
	{
		if (aura is not null) return;
		aura = new GpuParticles3D { Amount = 48, Lifetime = 2f, Position = new Vector3(0, 1.2f, 0) };
		var mat = new ParticleProcessMaterial
		{
			Direction = new Vector3(0, 1, 0), Spread = 40f,
			InitialVelocityMin = 0.5f, InitialVelocityMax = 1.5f,
			Gravity = new Vector3(0, 0.2f, 0), ScaleMin = 0.05f, ScaleMax = 0.15f, Color = color
		};
		aura.ProcessMaterial = mat;
		aura.DrawPass1 = new SphereMesh { Radius = 0.08f };
		parent.AddChild(aura);
	}
}
