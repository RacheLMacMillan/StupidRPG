using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IInitializable
{
	[SerializeField] private int _playerMoveSpeed;
	[SerializeField] private float _ValueOfSmoothingMoveSpeed;
	
	private Rigidbody2D _rigidbody;
	
	public void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		
		Debug.Log("Player Mover Initialized");
	}
	
	public void Move(Vector2 movementVelocity)
	{
		float multipliedSmoothedMoveSpeedByDeltaTime = _ValueOfSmoothingMoveSpeed * Time.deltaTime;
		
		float smoothedMoveSpeed = Mathf.Lerp
		(
			0,
			_playerMoveSpeed,
			multipliedSmoothedMoveSpeedByDeltaTime
		);
		
		Debug.Log(smoothedMoveSpeed);
		
		// float scaledMoveSpeed = smoothedMoveSpeed * Time.deltaTime;
		Vector2 scaledVelocity = movementVelocity * smoothedMoveSpeed;
		
		_rigidbody.MovePosition(_rigidbody.position + scaledVelocity);
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