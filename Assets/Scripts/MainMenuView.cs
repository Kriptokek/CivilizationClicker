using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button _startButton;
    [SerializeField] private GameObject _gameStage;
    [SerializeField] private GameObject _gameHud;

    public Button StartButton => _startButton;

    public GameObject GameStage => _gameStage;

    public GameObject GameHud => _gameHud;
}
