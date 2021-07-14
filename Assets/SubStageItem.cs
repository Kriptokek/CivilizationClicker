using System;
using UnityEngine;
using UnityEngine.UI;

public class SubStageItem : MonoBehaviour
{
	[SerializeField] private Button _openSubStageButton;
	[SerializeField] private Image _image;

	public event Action<int> ButtonClicked;

	public Button OpenSubStageButton => _openSubStageButton;

	public int SubStageToOpenId { get; private set; }


	private void OnEnable()
	{
		OpenSubStageButton.onClick.AddListener(OnOpenSubStageButtonClicked);
	}

	private void OnDisable()
	{
		OpenSubStageButton.onClick.RemoveListener(OnOpenSubStageButtonClicked);
	}

	public void Initialize(int subStageToOpenId, Sprite sprite)
	{
		SubStageToOpenId = subStageToOpenId;
		_image.sprite = sprite;
	}

	private void OnOpenSubStageButtonClicked()
	{
		ButtonClicked?.Invoke(SubStageToOpenId);
	}
}
