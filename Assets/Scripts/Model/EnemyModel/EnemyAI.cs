using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
	private EnemyState _state;
	private EnemyPathfinding _enemyPathfinding;
	
	private void Awake()
	{
		_enemyPathfinding = GetComponent<EnemyPathfinding>();
		_state = EnemyState.Roaming;
	}
	
	private void Start()
	{
		StartCoroutine(RoamingRoutine());
	}
	
	private IEnumerator RoamingRoutine()
	{
		
		while (_state == EnemyState.Roaming)
		{
			Debug.Log("asdf");
			Vector2 roamPosition = GetRoamingPosition();
			_enemyPathfinding.MoveTo(roamPosition);
			yield return new WaitForSeconds(2);
		}
	}
	
	private Vector2 GetRoamingPosition()
	{
		return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
	}
}