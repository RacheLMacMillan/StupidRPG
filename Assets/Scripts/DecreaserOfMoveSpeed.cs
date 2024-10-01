using UnityEngine;

public class DecreaserOfMoveSpeed : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		PlayerMover playerMover = other.GetComponent<PlayerMover>();
		
		if (playerMover != null)
		{
			playerMover.DecreasePlayerSpeed(5);
		}
	}
}