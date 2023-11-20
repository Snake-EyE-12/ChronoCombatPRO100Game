using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public const int HEAD = 0;
    public const int CHEST = 1;
    public const int HAND = 2;
    public const int BACKPACK = 3;
    public InventorySlot[] slots = new InventorySlot[4];
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