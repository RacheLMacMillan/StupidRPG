using System;
using UnityEngine;

public class LookAtTestScript : MonoBehaviour
{
	[SerializeField] private GameObject _target;
	[SerializeField] private float _time;
	[SerializeField] private float _smoothValue;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		CameraFollower cameraFollower = other.GetComponent<CameraFollower>();
		
		if (cameraFollower == null)
		{
			throw new NullReferenceException();
		}
		else
		{
			cameraFollower.ChangeTargetForSomeTime(_target, _time, _smoothValue);
			
			gameObject.SetActive(false);
		}
	}
}
