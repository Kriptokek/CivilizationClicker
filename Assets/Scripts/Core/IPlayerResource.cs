using System.Collections.Generic;

namespace CivilizationClicker.PlayerProfileNameSpace
{
	public interface IPlayerResource
	{
		int WoodenCurrency { get; }
		int IronCurrency { get; }
		int GoldCurrency { get; }
		List<Warrior> Units { get; }
		void AddWoodenCurrency(int woodenCount);
		void AddIronCurrency(int ironCount);
		void AddGoldCurrency(int goldCount);
		void RemoveWoodenCurrency(int woodenCount);
		void RemoveIronCurrency(int ironCount);
		void RemoveGoldCurrency(int goldCount);
	}
}