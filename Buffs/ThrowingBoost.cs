using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CrystiliumMod.Buffs
{
	public class ThrowingBoost : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Throwing Boost");
			Description.SetDefault("+10% throwing damage");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.thrownDamage *= 1.1f;
		}
	}
}