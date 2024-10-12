using UnityEngine;

public class LookAtTestScript : MonoBehaviour
{
	[SerializeField] private CameraFollower _cameraFollower;
	[SerializeField] private GameObject _target;
	[SerializeField] private float _time;
	[SerializeField] private float _smoothValue;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		_cameraFollower.ChangeTargetForSomeTime(_target, _time, _smoothValue);
	}
	
	private void OnDestroy()
	{
		Destroy(gameObject);
	}
}
