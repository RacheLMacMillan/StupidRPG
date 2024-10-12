using UnityEngine;

public class PlayerAnimationView : MonoBehaviour
{
	private Animator _animator;
	private SpriteRenderer _spriteRenderer;
	
	private void Awake()
	{
		_animator = GetComponent<Animator>();
		_spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	public void ChangeMoveAnimationByDirection(Vector2 direction)
	{
		
	}
}