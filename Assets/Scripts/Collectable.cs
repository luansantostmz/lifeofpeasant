using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Collectable : MonoBehaviour
{	
	public CollectableType type;
	public Sprite icon;

	public Rigidbody2D rb2d;

	private void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		Player player = col.GetComponent<Player>();
		
		if (player) 
		{
			Debug.Log("GOSTOSO");
			player.Inventory.Add(this);
			Destroy(this.gameObject);
		}		
	}
}

public enum CollectableType 
{
	NONE,
	REPOLHO,
	TERRAO,
}
