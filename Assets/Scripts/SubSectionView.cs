using System.Collections.Generic;
using System.Linq;
using CivilizationClicker;
using strange.extensions.mediation.impl;
using UnityEngine;

public class SubSectionView : View
{
    #region Fields

    [SerializeField] private float _instantiateTime;
    [SerializeField] private float _instantiateOffset;
    [SerializeField] private ClickableController _clickableItem;
    [SerializeField] private Transform _background;
    [SerializeField] private int _sectionNumber;
    [SerializeField] private int _currentMaxElement;

    #endregion

    #region Properties

    public ClickableController Item => _clickableItem;

    public float InstantiateTime => _instantiateTime;

    public Transform Background => _background;
    
    public IEnumerable<Element> Elements => Resources.LoadAll($"SectionElements{_sectionNumber}", typeof(Element)).Cast<Element>();

    public int CurrentMaxElement => _currentMaxElement;
    
    public float InstantiateOffset => _instantiateOffset;

    #endregion
    
    [Inject] public SignalInstantiate jSignalInstantiate { get; set; }
}
