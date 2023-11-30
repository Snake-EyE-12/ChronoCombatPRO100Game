using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WizardHat : Hat
{
    // Every third spell played is cast immediately after being played

    //WizardHat wizardHat = new WizardHat();
    public override void OnPlay()
    {
        InventoryManager.Instance().EquipItem(this);
    }
    public override void OnEquip()
    {
        EffectController.wizardHat = true;
        
    }

    public override void OnUnequipped()
    {
        EffectController.wizardHat = false;
        
    }
}
