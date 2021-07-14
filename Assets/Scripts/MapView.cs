using System.Collections;
using System.Collections.Generic;
using CivilizationClicker.PlayerProfileNameSpace;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class MapView : View
{
    [SerializeField] public Button _subStageButton;
    [SerializeField] public Button _startArenaButton;
    public Button SubStageButton => _subStageButton;
    public Button StartArenaButton => _startArenaButton;
}
