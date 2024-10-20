using System;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
	public event Action EnemySpawned;
	
	private void Awake()
	{
		EnemySpawned?.Invoke();
	}
}