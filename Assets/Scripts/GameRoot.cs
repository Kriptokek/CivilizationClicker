using strange.extensions.context.api;
using strange.extensions.context.impl;

namespace CivilizationClicker
{
	public class GameRoot : ContextView
	{
		private void Awake()
		{
			context = new GameContext(this, ContextStartupFlags.MANUAL_MAPPING);
			context.Start();
		}
	}	
}
