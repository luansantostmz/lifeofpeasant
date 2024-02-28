using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{	
    public  Inventory Inventory;


	private void Awake()
	{
		Inventory = new Inventory(30);
	}


	public void DropItem(Collectable item)
	{
		Vector3 spawnLocation = transform.position;

		Vector3 spawnOffset = Random.insideUnitCircle * 1.25f;

		Collectable droppedItem = Instantiate(item, spawnLocation + spawnOffset, Quaternion.identity);


		droppedItem.rb2d.AddForce(spawnOffset * .2f, ForceMode2D.Impulse);
	}

}
