using UnityEngine;

public class TreantScript : MonoBehaviour, IMovable, IAttackable, IDestructible
{
	[SerializeField] private float _moveSpeed;
	
	public void Move()
	{
		
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