using UnityEngine;

public class TreantScript : MonoBehaviour, IMovable, IAttackable, IDestructible
{
	[SerializeField] private float _moveSpeed;
	
	private Vector2 _moveDirection;
	private Rigidbody2D _rigidbody2D;

	private void Awake()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	public void Move()
	{
		float scaledMoveSpeed = _moveSpeed * Time.fixedDeltaTime;
		Vector2 scaledMoveDirection = _moveDirection + _rigidbody2D.position;
		
		_rigidbody2D.MovePosition(scaledMoveDirection * scaledMoveSpeed);
	}
	
	public void Attack()
	{
		
	}
	
	public void Destroy()
	{
		
	}
	
	public float GetMoveSpeed()
	{
		return _moveSpeed;
	}
}