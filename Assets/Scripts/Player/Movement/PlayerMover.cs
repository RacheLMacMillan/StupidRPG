using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
	[SerializeField] private float _playerMoveSpeed;
	[SerializeField] private float _ValueOfSmoothingMoveSpeed;
	
	private Rigidbody2D _rigidbody;
	
	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		
		Debug.Log("Player Mover Initialized");
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