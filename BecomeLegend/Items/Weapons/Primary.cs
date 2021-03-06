using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Items.Weapons
{
    public class Primary : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This ammo is used by all primary guns.");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
            item.ranged = true;
            item.width = 40;
            item.height = 30;
            item.maxStack = 1000;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("Primary");   //The projectile shoot when your weapon using this ammo
            item.ammo = item.type;              //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.OnFire, 300);
        }
    }
}
