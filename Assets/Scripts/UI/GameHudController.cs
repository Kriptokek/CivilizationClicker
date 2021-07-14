
public class GameHudController : ViewController<GameHudView>
{
	private void Start()
	{
		SetWoodenCurrencyText(1);
		View.jSignalOnWoodenCurrencyChanged.AddListener(SetWoodenCurrencyText);
	}

	private void OnDisable()
	{
		View.jSignalOnWoodenCurrencyChanged.RemoveListener(SetWoodenCurrencyText);
	}

	private void SetWoodenCurrencyText(int woodenAmount)
	{
		View.WoodenCurrencyText.text = View.jPlayerProfile.PlayerResource.WoodenCurrency.ToString();
	}
}
