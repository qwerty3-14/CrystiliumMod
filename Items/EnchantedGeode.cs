using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace CrystiliumMod.Items
{
	public class EnchantedGeode : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Enchanted Geode";
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 7000;
            item.rare = 5;
		}
	}
}