using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
	[SerializeField] private List<Component> _classes;
	
	private IInitializable _initializableClasses;
	
	private void DontAwake()
	{
		Debug.Log("Initializing is started");
		
		for (int i = 0; i < _classes.Count; i++)
		{
			_initializableClasses = _classes[i].GetComponent<IInitializable>();
			
			_initializableClasses.Initialize();
			
			Debug.Log(_classes[i] + " is Ready");
		}
		
		Debug.Log("Initializing is finished");
	}
}