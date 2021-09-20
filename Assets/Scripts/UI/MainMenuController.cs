
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
		var parent = transform.parent;
		
		Instantiate(View.GameHud, parent);
		Instantiate(View.Stage, parent);
	}
}