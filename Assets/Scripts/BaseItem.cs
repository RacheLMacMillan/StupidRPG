using System;
using UnityEngine;

public abstract class BaseItem : MonoBehaviour, IPickupable
{
	public bool _isPickedUp { get; private set; }

	private Action PickedUp => OnDestroy;

	public virtual void PickUp()
	{
		_isPickedUp = true;
		
		OnDestroy();
	}
	
	private void OnDestroy() 
	{
		PickedUp?.Invoke();
		
		Destroy(this.gameObject);
	}
}