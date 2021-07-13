using CivilizationClicker;
using CivilizationClicker.PlayerProfileNameSpace;
using strange.extensions.mediation.impl;
using UnityEngine;

public class ClickableView : View
{
	[SerializeField] private SpriteRenderer _clickableSpriteRenderer;
	[SerializeField] private Vector3 _offset;
	private int _elementId;
	private int _goldCurrencyProductivity;
	private int _nativeCurrencyProductivity;
	private NativeCurrencies _nativeCurrencies;

	public SpriteRenderer ClickableSpriteRenderer => _clickableSpriteRenderer;
	public int ElementId => _elementId;
	public int GoldCurrencyProductivity => _goldCurrencyProductivity;
	public int NativeCurrencyProductivity => _nativeCurrencyProductivity;
	public Vector3 Offset => _offset;
	
	[Inject] public SignalInstantiate jSignalInstantiate { get; set; }
	[Inject] public IPlayerProfile jPlayerProfile { get; set; }
	public NativeCurrencies NativeCurrencies => _nativeCurrencies;


	public void Initialize(Sprite sprite, int elementId, int goldCurrencyProductivity, int nativeCurrencyProductivity, NativeCurrencies nativeCurrencies)
	{
		_clickableSpriteRenderer.sprite = sprite;
		_elementId = elementId;
		_goldCurrencyProductivity = goldCurrencyProductivity;
		_nativeCurrencyProductivity = nativeCurrencyProductivity;
		_nativeCurrencies = nativeCurrencies;
	}
}