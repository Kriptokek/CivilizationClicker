
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
		gameObject.SetActive(false);
		Instantiate(View.GameHud, transform.parent);
		Instantiate(View.Stage, transform.parent);
	}
}