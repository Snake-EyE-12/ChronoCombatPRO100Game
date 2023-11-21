using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OminousRing : Weapon
{
    OminousRing ominousRing = new OminousRing();
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(ominousRing);
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
