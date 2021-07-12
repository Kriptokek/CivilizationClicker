using strange.extensions.mediation.impl;
using UnityEngine;

public class ViewController<T> : MonoBehaviour where T : View
{
	[SerializeField] private T _view;

	public T View => _view;
}