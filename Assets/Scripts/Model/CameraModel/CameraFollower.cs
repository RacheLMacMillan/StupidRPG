using System;
using System.Collections;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
	[SerializeField] private GameObject _target;
	
	[SerializeField] private Vector3 _offset;
	
	[SerializeField] private float _smoothingMoveValue;

	private void Awake()
	{
		_target = FindAnyObjectByType<Player>().gameObject;
	}
	
	private void FixedUpdate() // Fix this one
	{
		LookAtTarget();
	}
	
	public void ChangeTarget(GameObject newTarget)
	{
		if (newTarget == null)
		{
			throw new ArgumentNullException();
		}
		
		_target = newTarget;
	}
	
	public void ChangeTargetForSomeTime(GameObject newTarget, float waitForSeconds, float smoothValue)
	{
		if (newTarget == null)
		{
			throw new ArgumentNullException();
		}
		if (waitForSeconds < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		
		StartCoroutine(StartChangingTargetForSomeTime(newTarget, waitForSeconds, smoothValue));
	}
	
	private void LookAtTarget()
	{
		Vector3 targetPosition = _target.transform.position + _offset;
		
		Vector3 scaledFollowing = Vector3.Lerp
		(
			transform.position,
			targetPosition,
			_smoothingMoveValue
		);
		
		transform.position = scaledFollowing;
	}
	
	private IEnumerator StartChangingTargetForSomeTime(GameObject newTarget, float waitForSeconds, float smoothValue)
	{
		GameObject oldTarget = _target;
		float oldSmoothValue = _smoothingMoveValue;
		
		_smoothingMoveValue = smoothValue;
		_target = newTarget;
		
		yield return new WaitForSeconds(waitForSeconds);
		
		_target = oldTarget;
		_smoothingMoveValue = oldSmoothValue;
	}
}