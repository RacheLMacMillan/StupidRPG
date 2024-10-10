using System.Collections;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
	[SerializeField] private GameObject _target;
	
	[SerializeField] private Vector3 _offset;
	
	[SerializeField] private float _smoothingMoveValue;

	private GameObject _player;
	
	private void Awake()
	{
		_target = FindAnyObjectByType<Player>().gameObject;
		_player = _target;
	}
	
	public void FixedUpdate()
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
	
	public IEnumerator ChangeTargetBySomeTime(GameObject newTarget, float waitForSeconds)
	{
		_target = newTarget;
		
		yield return new WaitForSeconds(waitForSeconds);
		
		_target = _player;
	}
}