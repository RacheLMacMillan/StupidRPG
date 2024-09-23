using System.Collections.Generic;
using UnityEngine;

public class Initializer<T> : MonoBehaviour, IInitializable where T : MonoBehaviour
{
	[SerializeField] private List<T> _classes;
	
	private IInitializable _initializableClass;
	
	// [SerializeField] private PlayerInput _playerInput;
	// [SerializeField] private PlayerMover _playerMover;
	
	public void StartInitializing()
	{
		for (int i = 0; i < _classes.Count; i++)
		{
			_initializableClass = _classes[i].GetComponent<IInitializable>();
			
			_initializableClass.Initialize();
		}
		
		// _playerInput.Initialize();
		// _playerMover.Initialize();
	}
	
	
}