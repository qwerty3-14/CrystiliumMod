using System;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using CrystiliumMod.NPCs;

namespace CrystiliumMod.Buffs
{
	public class CrystalLeak : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Crystal Leak";
			Main.buffTip[Type] = "Creates dangerous crystals";
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			longerExpertDebuff = false;
		}

		float ticks = 0f;
		public override void Update(Player player, ref int buffIndex)
		{
			if (++ticks >= 6f) {
				ticks = 0f;
					Projectile.NewProjectile ((player.Center.X - 125) + Main.rand.Next (250), (player.Center.Y - 125) + Main.rand.Next (250), 0f, 0f, mod.ProjectileType ("Shatter" + (1 + Main.rand.Next (0, 3))), 14, 0, Main.myPlayer);
			}
		}
	}
}