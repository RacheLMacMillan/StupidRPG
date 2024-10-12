using UnityEngine;

public class LookAtTestScript : MonoBehaviour
{
	[SerializeField] private CameraFollower _cameraFollower;
	[SerializeField] private GameObject _target;
	[SerializeField] private float _time;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		_cameraFollower.ChangeTargetForSomeTime(_target, _time);
		
		OnDestroy();
	}
	
	private void OnDestroy()
	{
		Destroy(gameObject);
	}
}
