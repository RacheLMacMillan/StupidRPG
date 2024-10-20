using System;
using UnityEngine;

public class LooAtTarget : MonoBehaviour
{
	[SerializeField] private GameObject _target;
	[SerializeField] private float _time;
	[SerializeField] private float _smoothValue;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		Player player = other.gameObject.GetComponent<Player>();
		CameraFollower cameraFollower = FindFirstObjectByType<CameraFollower>();
		
			if (player == null)
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