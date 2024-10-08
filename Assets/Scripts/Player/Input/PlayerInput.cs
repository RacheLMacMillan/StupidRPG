using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] private PlayerMover _playerMover;
	[SerializeField] private PlayerDasher _playerDasher;
	
	private InputMap _inputMap;
	
	public void Awake()
	{
		_inputMap = new InputMap();
		
		_playerMover = GetComponent<PlayerMover>();
		_playerDasher = GetComponent<PlayerDasher>();
		
		_inputMap.PlayScene.Dash.performed += context => _playerDasher.Dash(_inputMap.PlayScene.Move.ReadValue<Vector2>());
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