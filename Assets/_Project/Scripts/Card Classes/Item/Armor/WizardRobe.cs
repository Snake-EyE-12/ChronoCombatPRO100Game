using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardRobe : Armor
{
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }

    public override void OnEquip()
    {
        EffectController.Instance().armorValue++;
    }

    public override void OnUnequipped()
    {
        EffectController.Instance().armorValue--;
    }
}
