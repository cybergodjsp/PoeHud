using PoeHUD.ExileBot;

namespace PoeHUD.Hud.Icons
{
	public class MonsterMinimapIcon : MinimapIcon
	{
		public MonsterMinimapIcon(Entity entity, string texture, int size, MinimapRenderPriority prio) : base(entity, texture, size, prio)
		{
		}
		public override bool Validate()
		{
			return this.Entity.IsValid;
		}
		public override bool WantsToRender()
		{
			return Settings.GetBool("MinimapIcons.Monsters") && this.Entity.IsAlive;
		}
	}
}
