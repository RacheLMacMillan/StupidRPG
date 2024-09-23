using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IInitializable
{
	private float _playerMoveSpeed = 10;
	
	private Rigidbody2D _rigidbody;
	
	public void Initialize()
	{
		Debug.Log("Player Mover");
		
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	public void Move(Vector2 movementVelocity)
	{
		float scaledMoveSpeed = _playerMoveSpeed * Time.deltaTime;
		Vector2 scaledVelocity = movementVelocity * scaledMoveSpeed;
		
		_rigidbody.MovePosition(_rigidbody.position + scaledVelocity);
	}
	
	public void IncreasePlayerSpeed(float value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		
		_playerMoveSpeed += value;
	}
	
	public void DecreasePlayerSpeed(float value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		
		_playerMoveSpeed -= value;
	}

	public float GetPlayerSpeedValue()
	{
		return _playerMoveSpeed;
	}
}