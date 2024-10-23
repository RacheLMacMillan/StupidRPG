using UnityEngine;

public class EnemyPathFinding : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 2f;
	
	private Rigidbody2D _rigidbody2D;
	private Vector2 _moveDirection;
	
	private void Awake()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	private void FixedUpdate()
	{

	}
	

}