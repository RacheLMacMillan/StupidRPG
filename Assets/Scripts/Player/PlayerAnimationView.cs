using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerAnimationView : MonoBehaviour
{
	private Animator _animator;
	private SpriteRenderer _spriteRenderer;
	
	private void Awake()
	{
		_animator = GetComponent<Animator>();
		_spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	public void ChangeMoveAnimationByDirection(Vector2 moveVelocity)
	{
		if (moveVelocity == Vector2.zero)
		{
			SetMoovingDirection(false, moveVelocity.x, moveVelocity.y);
			
			Debug.Log("Player Is Stopped");
		}
		else
		{
			SetMoovingDirection(true, moveVelocity.x, moveVelocity.y);
			
			Debug.Log("Player Is Mooving");
		}
	}
	
	private void SetMoovingDirection(bool isMooving, float directionX, float directionY)
	{
		_animator.SetBool(nameof(isMooving), isMooving);
		
		_animator.SetFloat(nameof(directionX), directionX);
		_animator.SetFloat(nameof(directionY), directionY);
		
		if (directionX < 0)
		{
			_spriteRenderer.flipX = true;
		}
		else
		{
			_spriteRenderer.flipX = false;
		}
	}
}