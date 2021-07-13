using strange.extensions.signal.impl;
using UnityEngine;

namespace CivilizationClicker
{
	public class SignalInstantiate : Signal<int, Vector3>{}
	
	public class SignalOnGoldCurrencyChanged : Signal<int>{}
	
	public class SignalOnWoodenCurrencyChanged : Signal<int>{}
	
	public class SignalOnIronCurrencyChanged : Signal<int>{}
}
