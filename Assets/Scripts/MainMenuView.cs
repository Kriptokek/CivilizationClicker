using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button _startButton;

    public Button StartButton => _startButton;
}
