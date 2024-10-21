using UnityEngine;

public class EnemyPathFinding : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 2f;
	
	private Rigidbody2D rigidbody2D;
	private Vector2 moveDirection;
	
	private void Awake() {
		rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	private void FixedUpdate() {
		rigidbody2D.MovePosition(rigidbody2D.position + moveDirection * (moveSpeed * Time.fixedDeltaTime));
	}
	
	public void MoveTo(Vector2 targetPosition)
	{
		moveDirection = targetPosition;
	}
}