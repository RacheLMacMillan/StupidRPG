using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
	public float PlayerMoveSpeed { get; private set; }
	
	private float _ValueOfSmoothingMoveSpeed { get; }
	
	private Rigidbody2D _rigidbody;
	
	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		
		Debug.Log("Player Mover Initialized");
	}
	
	public void Move(Vector2 movementVelocity)
	{
		
		float scaledMoveSpeed = PlayerMoveSpeed * Time.deltaTime;
		Vector2 scaledVelocity = movementVelocity * scaledMoveSpeed;
		
		_rigidbody.MovePosition(_rigidbody.position + scaledVelocity);
	}
	
	public void IncreasePlayerSpeed(float value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		
		PlayerMoveSpeed += value;
	}
	
	public void DecreasePlayerSpeed(float value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		
		PlayerMoveSpeed -= value;
	}
}