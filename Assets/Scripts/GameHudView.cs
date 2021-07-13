using CivilizationClicker;
using CivilizationClicker.PlayerProfileNameSpace;
using strange.extensions.mediation.impl;
using TMPro;
using UnityEngine;

public class GameHudView : View
{
    [SerializeField] private TextMeshProUGUI _woodenCurrencyText;

    public TextMeshProUGUI WoodenCurrencyText => _woodenCurrencyText;
    
    [Inject] public SignalOnWoodenCurrencyChanged jSignalOnWoodenCurrencyChanged { get; set; }
    [Inject] public IPlayerProfile jPlayerProfile { get; set; }
}
