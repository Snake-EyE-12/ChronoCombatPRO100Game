using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OminousRing : Weapon
{
    // Spells are cast immediately after being played. Deals dmg equal to manaCost.

    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }

    public override void OnEquip()
    {
        EffectController.ominousRing = true;
    }

    public override void OnUnequipped()
    {
        EffectController.ominousRing = false;
    }
}
