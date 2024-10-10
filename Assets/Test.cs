using UnityEngine;

public class Test : MonoBehaviour
{  
	[SerializeField] private CameraFollower _follower;
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.O))
		{
			Debug.Log("Input O");
			
			StartCoroutine(_follower.ChangeTargetBySomeTime(gameObject, 3));
		}
	}
}
