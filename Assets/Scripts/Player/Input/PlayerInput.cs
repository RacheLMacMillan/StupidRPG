using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] private PlayerMover _playerMover;
	
	private InputMap _inputMap;
	
	public void Awake()
	{
		_inputMap = new InputMap();
		
		_playerMover = GetComponent<PlayerMover>();
	
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