using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
	private States _state;
	private EnemyPathFinding _enemyPathFinding;
	
	private void Awake()
	{
		_enemyPathFinding = GetComponent<EnemyPathFinding>();
		_state = States.Roaming;
	}
	
	private void Start()
	{
		StartCoroutine(RoamingRoutine());
	}

	private IEnumerator RoamingRoutine()
	{
		while (_state == States.Roaming)
		{
			Vector2 roamPosition = GetRoamingPosition();
			_enemyPathFinding.MoveTo(roamPosition);
			yield return new WaitForSeconds(2f);
		}
	}

	private Vector2 GetRoamingPosition()
	{
		return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
	}
}