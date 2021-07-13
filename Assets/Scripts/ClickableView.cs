using CivilizationClicker;
using strange.extensions.mediation.impl;
using UnityEngine;

public class ClickableView : View
{
	[SerializeField] private SpriteRenderer _clickableSpriteRenderer;
	[SerializeField] private Vector3 _offset;
	private int _elementId;

	public SpriteRenderer ClickableSpriteRenderer => _clickableSpriteRenderer;
	public int ElementId => _elementId;
	public Vector3 Offset => _offset;
	
	[Inject] public SignalInstantiate jSignalInstantiate { get; set; }

	public void Initialize(Sprite sprite, int elementId)
	{
		_clickableSpriteRenderer.sprite = sprite;
		_elementId = elementId;
	}
}