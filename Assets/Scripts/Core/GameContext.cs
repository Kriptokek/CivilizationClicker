using CivilizationClicker.PlayerProfileNameSpace;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

namespace CivilizationClicker
{
	public class GameContext : MVCSContext
	{
		public GameContext(MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
		{
        
		}
    
		public override IContext Start()
		{
			base.Start();
			return this;
		}

		protected override void addCoreComponents()
		{
			base.addCoreComponents();
			injectionBinder.Unbind<ICommandBinder>();  
			injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
			injectionBinder.Bind<MVCSContext>().ToValue(this).ToName(ContextKeys.CONTEXT);
		}

		protected override void mapBindings()
		{
			base.mapBindings();
			PlayerProfileBinds();
			SignalBinds();
		}

		private void PlayerProfileBinds()
		{
			injectionBinder.Bind<IPlayerProfile>().To<PlayerProfile>().ToSingleton();
			injectionBinder.Bind<IPlayerResource>().To<PlayerResource>().ToSingleton();
		}

		private void SignalBinds()
		{
			injectionBinder.Bind<SignalInstantiate>().ToSingleton();
			injectionBinder.Bind<SignalOnGoldCurrencyChanged>().ToSingleton();
			injectionBinder.Bind<SignalOnWoodenCurrencyChanged>().ToSingleton();
			injectionBinder.Bind<SignalOnIronCurrencyChanged>().ToSingleton();
		}
	}
}
