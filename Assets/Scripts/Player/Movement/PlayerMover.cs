using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IInitializable
{
	public float _playerMoveSpeed 
	{ 
		get
		{
			return _playerMoveSpeed;
		}
		
		private set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			
			_playerMoveSpeed = value;
		}
	}
	
	private Rigidbody2D _rigidbody;
	
	public void Initialize()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	public void Move(Vector2 movementVelocity)
	{
		float scaledMoveSpeed = _playerMoveSpeed * Time.deltaTime;
		Vector2 scaledVelocity = movementVelocity * scaledMoveSpeed;
		
		_rigidbody.MovePosition(_rigidbody.position + scaledVelocity);
	}
}