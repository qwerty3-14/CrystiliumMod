using Terraria.ModLoader;

namespace CrystiliumMod.Items
{
	public class CrystalKey : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crystal Key";
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			AddTooltip("Unlocks the secrets of the shining caves");
			item.value = 100000;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ShinyGemstone", 5);
			recipe.AddIngredient(327, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}