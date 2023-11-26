using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Strike : Action
{
    public Strike()
    {
        manaCost = 1;
    }

    public override void OnPlay()
    {
        Debug.Log("Strike Played");
        CombatInfo.Instance().controller.DealDamageToEnemy(6);
    }
}
