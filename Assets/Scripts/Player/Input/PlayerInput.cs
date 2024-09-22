using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] private PlayerMover _playerMover;
	
	private InputMap _inputMap;
	
	private void Awake()
	{
		_inputMap = new InputMap();
		

	}
	
	private void OnEnable()
	{
		_inputMap.Enable();
	}
	
	private void OnDisable()
	{
		_inputMap.Disable();
	}
	
	private void Update()
	{
		_playerMover.Move(_inputMap.PlayScene.Move.ReadValue<Vector2>());
	}
}