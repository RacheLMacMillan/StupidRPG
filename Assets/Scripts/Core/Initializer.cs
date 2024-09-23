using System.Collections.Generic;
using UnityEngine;

public class Initializer<T> : MonoBehaviour, IInitializable where T : MonoBehaviour
{
	private IInitializable _initializableClass;
	
	// [SerializeField] private PlayerInput _playerInput;
	// [SerializeField] private PlayerMover _playerMover;
	
	public void StartInitializing(List<T> classes)
	{
		for (int i = 0; i < classes.Count; i++)
		{
			_initializableClass = classes[i].GetComponent<IInitializable>();
			
			_initializableClass.Initialize();
		}
		
		// _playerInput.Initialize();
		// _playerMover.Initialize();
	}
}