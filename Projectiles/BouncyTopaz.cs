using Terraria.ModLoader;

namespace CrystiliumMod.Projectiles
{
	public class BouncyTopaz : ModProjectile
	{
		public override void SetDefaults()
		{
			//projectile.name = "Bouncy Topaz";
			//projectile.timeLeft = 300;
			//projectile.friendly = true;
			//projectile.light = 0.5f;
			projectile.CloneDefaults(Terraria.ID.ProjectileID.BallofFire);
			//Main.projFrames[projectile.type] = 3;
		}
	}
}