using UnityEngine;

public class EntryPoint : MonoBehaviour 
{
	[SerializeField] private PlayerInput _playerInput;
	[SerializeField] private PlayerMover _playerMover;
	
	private void Awake()
	{
		_playerInput.Initialize();
		_playerMover.Initialize();
	}
}