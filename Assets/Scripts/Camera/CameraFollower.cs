using UnityEngine;

public class CameraFollower : MonoBehaviour
{
	[SerializeField] private GameObject _target;
	
	[SerializeField] private float _smoothingMoveValue;
	
	[SerializeField] private Vector3 _offset;
	
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
}