using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBehavior : MonoBehaviour
{
    int CastFireball()
    {
        return 15;
    }

    int Strike()
    {
        return 6;
    }

    bool EquipWizardStaff()
    {
        return true;
    }

    int UseHealPotion(int mana)
    {
        if (mana < 2) return 0;
        return 5;
    }
};
