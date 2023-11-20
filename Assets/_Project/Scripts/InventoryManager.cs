using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public const int HEAD = 0;
    public const int CHEST = 1;
    public const int HAND = 2;
    public InventorySlot[] slots = new InventorySlot[3];
    public void EquipItem(int slot, Item item) {
        slots[slot].swap(item);
    }
}

public class InventorySlot
{
    public Item itemCard;
    public void swap(Item newItem) {
        //if(itemCard != null) itemCard.OnEndUsage();
        itemCard = newItem;
        //if(newItem != null) newItem.OnEquipped();
    }
}