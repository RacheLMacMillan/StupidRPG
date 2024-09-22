using UnityEngine;

public class EntryPoint : MonoBehaviour 
{
	private GameObject _gameObject;
	private IInitializable _initializable;
	
	private void Awake()
	{
		_initializable = _gameObject.GetComponent<IInitializable>();
		
		_initializable.Initialize();
	}
}