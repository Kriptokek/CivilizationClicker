using System;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class MapController : ViewController<MapView>
{
    private void OnEnable()
    {
        View.SubStageButton.onClick.AddListener(SubStageReturn);
        View.StartArenaButton.onClick.AddListener(StartArena);
    }

    private void OnDisable()
    {
        View.SubStageButton.onClick.RemoveListener(SubStageReturn);
        View.StartArenaButton.onClick.RemoveListener(StartArena);
    }


    private void StartArena()
    {
        Debug.Log("Starting arena");
    }
    private void SubStageReturn()
    {
        Debug.Log("Return to SubStage");
    }
}
