using System.Collections;
using UnityEngine;

public abstract class EnemyAI : MonoBehaviour
{
	private States _state;
	
	private Vector2 _moveDirection;
	
	
	private void Awake()
	{
		_state = States.Roaming;
	}
	
	private void Start()
	{
		StartCoroutine(RoamingRoutine());
	}

	public IEnumerator RoamingRoutine()
	{
		while (_state == States.Roaming)
		{
			Vector2 roamPosition = GetRoamingPosition();
			SetTargetPosition(roamPosition);
			yield return new WaitForSeconds(2f);
		}
	}

	public virtual Vector2 GetRoamingPosition()
	{
		return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
	}
	
	private void SetTargetPosition(Vector2 targetPosition)
	{
		_moveDirection = targetPosition;
	}
}