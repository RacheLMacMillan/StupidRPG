using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerDasher : MonoBehaviour
{
	[SerializeField] private float _forceOfDash;
	[SerializeField] private int _waitingForReset;
	
	private Rigidbody2D _rigidbody;
	
	private bool _canDash;
	
	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		
		StartCoroutine(ResetDash());
	}	
	public void Dash(Vector2 direction)
	{
		if (_canDash == false)
		{
			throw new ArgumentException();
		}
		
		_rigidbody.MovePosition(_rigidbody.position + (_forceOfDash * direction * Time.deltaTime));
		
		Debug.Log("Do dash");
		
		_canDash = false;
		
		ResetDash();
	}
	
	private IEnumerator ResetDash()
	{
		yield return new WaitForSeconds(_waitingForReset);
		
		_canDash = true;
	}
}