using strange.extensions.mediation.impl;
using UnityEngine;

public class GameStageView : View
{
    [SerializeField] private float _instantiateTime;
    [SerializeField] private GameObject _clickableItem;
    [SerializeField] private Transform _background;

    public GameObject Item => _clickableItem;

    public float InstantiateTime => _instantiateTime;

    public Transform Background => _background;
}
