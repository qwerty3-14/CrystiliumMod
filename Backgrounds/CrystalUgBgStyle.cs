using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CrystiliumMod.Backgrounds
{
	public class CrystalUgBgStyle : ModUgBgStyle
	{
		public override bool ChooseBgStyle()
		{
			return Main.LocalPlayer.GetModPlayer<CrystalPlayer>().ZoneCrystal;
		}

		public override void FillTextureArray(int[] textureSlots)
		{
			textureSlots[0] = mod.GetBackgroundSlot("Backgrounds/CrystalBiomeUG0");
			textureSlots[1] = mod.GetBackgroundSlot("Backgrounds/CrystalBiomeUG1");
			textureSlots[2] = mod.GetBackgroundSlot("Backgrounds/CrystalBiomeUG2");
			textureSlots[3] = mod.GetBackgroundSlot("Backgrounds/CrystalBiomeUG3");
		}
	}
}