
public class MainMenuController : ViewController<MainMenuView>
{
	private void OnEnable()
	{
		View.StartButton.onClick.AddListener(StartGame);
	}

	private void OnDisable()
	{
		View.StartButton.onClick.RemoveListener(StartGame);
	}

	private void StartGame()
	{
		Instantiate(View.GameStage, gameObject.transform.parent);
	}
}