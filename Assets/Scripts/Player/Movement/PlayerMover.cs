using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IInitializable
{
	[SerializeField] private float _startingPlayerSpeed;
	
	public float _playerMoveSpeed = 10;
	// { 
	// 	get
	// 	{
	// 		return _playerMoveSpeed;
	// 	}
		
	// 	private set
	// 	{
	// 		if (value < 0)
	// 		{
	// 			throw new ArgumentOutOfRangeException("value");
	// 		}
			
	// 		_playerMoveSpeed = value;
	// 	}
	// }
	
	private Rigidbody2D _rigidbody;
	
	public void Initialize()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		
		ChangeMoveSpeed(_startingPlayerSpeed);
	}
	
	public void Move(Vector2 movementVelocity)
	{
		float scaledMoveSpeed = _playerMoveSpeed * Time.deltaTime;
		Vector2 scaledVelocity = movementVelocity * scaledMoveSpeed;
		
		_rigidbody.MovePosition(_rigidbody.position + scaledVelocity);
	}
	
	public void ChangeMoveSpeed(float speed)
	{
		_playerMoveSpeed = speed;
	}
}