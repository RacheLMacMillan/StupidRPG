using UnityEngine;

public class IncreaserOfMoveSpeed : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		PlayerMover playerMover = other.GetComponent<PlayerMover>();
		
		if (playerMover != null)
		{
			playerMover.IncreasePlayerSpeed(5);
		}
	}
}