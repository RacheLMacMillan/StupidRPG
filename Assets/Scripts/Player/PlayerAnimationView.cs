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
	
	public void ChangeMoveAnimationByDirection(Vector2 scaledDirection)
	{
		if (scaledDirection == Vector2.zero)
		{
			SetMoovingDirection(false, scaledDirection.x, scaledDirection.y);
		}
		else
		{
			SetMoovingDirection(true, scaledDirection.x, scaledDirection.y);
		}
	}
	
	private void SetMoovingDirection(bool isMooving, float directionX, float directionY)
	{
		_animator.SetBool(nameof(isMooving), isMooving);
		
		_animator.SetFloat(nameof(directionX), directionX);
		_animator.SetFloat(nameof(directionY), directionY);
	}
}