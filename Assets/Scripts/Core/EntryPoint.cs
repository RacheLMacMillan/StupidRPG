using UnityEngine;

public class EntryPoing : MonoBehaviour	
{
	[SerializeField] private Component[] _classes;
	
	private IInitializable _initializableClass;
	
	private void Awake()
	{
		for (int i = 0; i < _classes.Length; i++)
		{
			_initializableClass = _classes[i].GetComponent<IInitializable>();
			
			_initializableClass.Initialize();
			
			_initializableClass = null;
			_classes[i] = null;
		}
	}
}