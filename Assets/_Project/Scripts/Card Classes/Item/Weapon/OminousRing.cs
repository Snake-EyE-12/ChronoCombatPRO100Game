using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OminousRing : Weapon
{
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }

    public override void OnEquip()
    {
        EffectController.Instance().ominousRing = true;
    }

    public override void OnUnequipped()
    {
        EffectController.Instance().ominousRing = false;
    }
}
