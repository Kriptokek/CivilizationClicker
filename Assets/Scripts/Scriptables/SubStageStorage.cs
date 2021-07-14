using UnityEngine;

[CreateAssetMenu(fileName = "SubStage", menuName = "Assets/SubStage")]
public class SubStageStorage : ScriptableObject
{
	public GameObject SubStagePrefab;
	public Sprite ButtonSprite;
	public int Number;
}
