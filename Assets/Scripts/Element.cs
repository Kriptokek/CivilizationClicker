using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "Assets/Element")]
public class Element : ScriptableObject
{
	public int Number;
	public Sprite Sprite;
	public int GoldProductivity;
	public int NativeProductivity;
	public NativeCurrencies NativeCurrencies;
}

public enum NativeCurrencies
{
	Wooden = 0,
	Iron = 1
}