using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WizardHat : Hat
{
    //WizardHat wizardHat = new WizardHat();
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }
    public override void OnEquip()
    {
        EffectController.Instance().wizardHat = true;
    }

    public override void OnUnequipped()
    {
        EffectController.Instance().wizardHat = false;
    }
}
