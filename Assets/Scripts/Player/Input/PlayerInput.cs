using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] private PlayerMover _playerMover;
	[SerializeField] private PlayerJumper _playerJumper;
	
	private InputMap _inputMap;
	
	public void Awake()
	{
		_inputMap = new InputMap();
		
		_playerMover = GetComponent<PlayerMover>();
		_playerJumper = GetComponent<PlayerJumper>();
	
		Debug.Log("Player Input Initialized");
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