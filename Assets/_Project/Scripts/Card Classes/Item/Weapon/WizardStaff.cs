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
        // Decide which approach to take
        EffectController.Instance().wizardStaff = true;
        EffectController.Instance().castCost--;
    }

    public override void OnUnequipped()
    {
        // Same here
        EffectController.Instance().wizardStaff = false;
        EffectController.Instance().castCost++;
    }
}
