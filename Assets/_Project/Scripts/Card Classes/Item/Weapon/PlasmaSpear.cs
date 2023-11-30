using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlasmaSpear : Weapon
{
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }

    public override void OnEquip()
    {
        EffectController.plasmaSpear = true;
    }

    public override void OnUnequipped()
    {
        EffectController.plasmaSpear = false;
    }
}
