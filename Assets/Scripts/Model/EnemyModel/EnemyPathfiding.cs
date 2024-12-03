using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
	[SerializeField] private float _moveSpeed;
	
	private Rigidbody2D _rigidbody2D;
	private Vector2 _moveDirection;
	
	private void Awake()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	private void FixedUpdate() {
		_rigidbody2D.MovePosition(_rigidbody2D.position + _moveDirection * (_moveSpeed * Time.fixedDeltaTime));
	}
	
	public void MoveTo(Vector2 targetPosition)
	{
		_moveDirection = targetPosition;
	}
}