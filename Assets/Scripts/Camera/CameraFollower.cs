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
	
	public void FixedUpdate()
	{
		LookAtTarget();
	}
	
	public IEnumerator ChangeTargetForSomeTime(GameObject newTarget, float waitForSeconds)
	{
		GameObject oldTarget = _target;
		
		_target = newTarget;
		
		yield return new WaitForSeconds(waitForSeconds);
		
		_target = oldTarget;
	}
	
	public void ChangeTarget(GameObject newTarget)
	{
		_target = newTarget;
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
}