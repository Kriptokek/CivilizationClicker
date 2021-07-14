using System.Collections;
using System.Collections.Generic;
using CivilizationClicker;
using CivilizationClicker.PlayerProfileNameSpace;
using strange.examples.signals;
using strange.extensions.mediation.impl;
using UnityEngine;

public class ArenaProfileView : View
{
    
    [Inject] public IPlayerProfile jPlayerProfile { get; set; }
}
