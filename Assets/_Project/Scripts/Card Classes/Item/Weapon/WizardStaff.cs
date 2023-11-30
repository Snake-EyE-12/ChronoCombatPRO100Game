using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WizardStaff : Weapon
{

    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }

    public override void OnEquip()
    {
        EffectController.manaModifier++;
    }

    public override void OnUnequipped()
    {
        EffectController.manaModifier--;
    }
}
