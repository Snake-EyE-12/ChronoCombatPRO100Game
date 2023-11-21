using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class InventoryManager : Singleton<InventoryManager>
{
    public const int HEAD = 0;
    public const int CHEST = 1;
    public const int HAND = 2;
    public const int BACKPACK = 3;
    public InventorySlot[] slots = new InventorySlot[4];
    public void EquipItem(Item item)
    {
        slots[item.slot].swap(item);
    }
}

public class InventorySlot
{
    public Item itemCard;
    public void swap(Item newItem)
    {
        if (itemCard != null) itemCard.OnUnequipped();
        itemCard = newItem;
        if (newItem != null) newItem.OnEquip();
    }
}