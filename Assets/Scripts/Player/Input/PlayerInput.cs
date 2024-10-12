using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerAnimationView))]
public class PlayerInput : MonoBehaviour
{
	[Header("Model")]
	[SerializeField] private PlayerMover _playerMover;
	
	[Header("View")]
	[SerializeField] private PlayerAnimationView _playerAnimationView;
	
	private InputMap _inputMap;
	
	public void Awake()
	{
		_inputMap = new InputMap();
		
		_playerMover = GetComponent<PlayerMover>();
		_playerAnimationView = GetComponent<PlayerAnimationView>();
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
		UpdateModel();
		UpdateView();
	}
	
	private void UpdateModel()
	{
		_playerMover.Move(_inputMap.PlayScene.Move.ReadValue<Vector2>());
	}
	
	private void UpdateView()
	{
		_playerAnimationView.ChangeMoveAnimationByDirection(_inputMap.PlayScene.Move.ReadValue<Vector2>());
	}
}