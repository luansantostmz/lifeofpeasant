using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
	public GameObject inventory;
	public Slot_UI slotPrefab;
	public Animator anim;
	public Player player;

	public List<Slot_UI> slots = new List<Slot_UI>();

	private void Awake()
	{
		anim.SetBool("open", false);
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab)) 
		{
			ToggleInventory();
		}
		Refresh();
	}

	public void ToggleInventory() 
	{
		anim.SetBool("open", !anim.GetBool("open"));		
	}

	public void Refresh()
	{
		if (slots.Count == 0) return;
       
        for (int i = 0; i < slots.Count; i++)
		{
			if (player.Inventory.slots[i].type != CollectableType.NONE)
			{				
				slots[i].SetItem(player.Inventory.slots[i]);
			}
			else
			{
				slots[i].SetEmpty();
			}
		}
	}

	public void Remove(int slotID)
	{
		player.Inventory.Remove(slotID);
	}
}
