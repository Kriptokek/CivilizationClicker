using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button _startButton;
    [SerializeField] private GameObject _gameHud;
    [SerializeField] private GameObject _stage;

    public Button StartButton => _startButton;

    public GameObject GameHud => _gameHud;

    public GameObject Stage => _stage;
}
