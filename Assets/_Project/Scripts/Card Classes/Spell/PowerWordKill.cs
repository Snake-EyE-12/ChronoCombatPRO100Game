using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PowerWordKill : Spell
{
    public PowerWordKill()
    {
        manaCost = 6;
    }

    public override void OnPlay()
    {
        /*
        if (castingTime == 0)
        {
            if (Enemy.type == "boss")
            {
                CombatController.Instance().DealDamageToEnemy(50);
            }
            else
            {
                CombatController.Instance().DealDamageToEnemy(999);
            }
            return;
        }
        castingTime--;
        */
    }
}
