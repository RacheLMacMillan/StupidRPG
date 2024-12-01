using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
	public Vector2 _scaledMoveDirection { get; private set; }
	
	[SerializeField] private int _playerMoveSpeed;
	[SerializeField] private float _ValueOfSmoothingMoveSpeed;
	
	private Rigidbody2D _rigidbody;
	private Vector2 _playerVelocity;
	
	public void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		
		Debug.Log("Player Mover Initialized");
	}
	
	public void Move(Vector2 movementVelocity)
	{
		float scaledMoveSpeed = _playerMoveSpeed * Time.deltaTime;
		
		Vector2 smoothedDirection = Vector2.Lerp
		(
			_playerVelocity,
			movementVelocity,
			_ValueOfSmoothingMoveSpeed
		);
		
		_playerVelocity = smoothedDirection;
		
		_scaledMoveDirection = smoothedDirection * scaledMoveSpeed;
		
		_rigidbody.MovePosition(_rigidbody.position + _scaledMoveDirection);
	}
	
	public void IncreasePlayerSpeed(float value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		
		_playerMoveSpeed += Mathf.RoundToInt(value);
	}
	
	public void DecreasePlayerSpeed(float value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		
		_playerMoveSpeed -= Mathf.RoundToInt(value);
	}
	
	public int GetPlayerMoveSpeed()
	{
		return _playerMoveSpeed;
	}
}