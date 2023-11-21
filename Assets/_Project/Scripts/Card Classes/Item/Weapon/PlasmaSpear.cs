using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaSpear : Weapon
{
    PlasmaSpear plasmaSpear = new PlasmaSpear();
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(plasmaSpear);
    }

    public override void OnEquip()
    {
        EffectController.Instance().plasmaSpear = true;
    }

    public override void OnUnequipped()
    {
        EffectController.Instance().plasmaSpear = false;
    }
}
