
using UnityEngine;

namespace CivilizationClicker.PlayerProfileNameSpace
{
	public class PlayerResource : IPlayerResource
	{
		private int _woodenCurrency;
		private int _ironCurrency;
		private int _goldCurrency;
		
		[Inject] public SignalOnWoodenCurrencyChanged jSignalOnWoodenCurrencyChanged { get; set; }
		[Inject] public SignalOnGoldCurrencyChanged jSignalOnGoldCurrencyChanged { get; set; }
		[Inject] public SignalOnIronCurrencyChanged jSignalOnIronCurrencyChanged { get; set; }

		public int WoodenCurrency
		{
			get
			{
				return _woodenCurrency;
			}
			private set
			{
				_woodenCurrency = value;
				jSignalOnWoodenCurrencyChanged.Dispatch(_woodenCurrency);
			}
		}

		public int IronCurrency
		{
			get
			{
				return _ironCurrency;
			}
			set
			{
				_ironCurrency = value;
				jSignalOnIronCurrencyChanged.Dispatch(_ironCurrency);
			}
		}

		public int GoldCurrency
		{
			get
			{
				return _goldCurrency;
			}
			set
			{
				_goldCurrency = value;
				jSignalOnGoldCurrencyChanged.Dispatch(_goldCurrency);
			}
		}

		public void AddWoodenCurrency(int woodenCount)
		{
			if (woodenCount < 0)
			{
				Debug.LogError("Value of wooden cannot be less than zero!");
			}

			WoodenCurrency += woodenCount;
		}

		public void AddIronCurrency(int ironCount)
		{
			if (ironCount < 0)
			{
				Debug.LogError("Value of iron cannot be less than zero!");
			}

			IronCurrency += ironCount;
		}

		public void AddGoldCurrency(int goldCount)
		{
			if (goldCount < 0)
			{
				Debug.LogError("Value of gold cannot be less than zero!");
			}

			GoldCurrency += goldCount;
		}

		public void RemoveWoodenCurrency(int woodenCount)
		{
			if (woodenCount < 0)
			{
				Debug.LogError("Value of wooden cannot be less than zero!");
			}

			WoodenCurrency -= woodenCount;
		}

		public void RemoveIronCurrency(int ironCount)
		{
			if (ironCount < 0)
			{
				Debug.LogError("Value of iron cannot be less than zero!");
			}

			IronCurrency -= ironCount;
		}

		public void RemoveGoldCurrency(int goldCount)
		{
			if (goldCount < 0)
			{
				Debug.LogError("Value of gold cannot be less than zero!");
			}

			GoldCurrency -= goldCount;
		}
	}
}