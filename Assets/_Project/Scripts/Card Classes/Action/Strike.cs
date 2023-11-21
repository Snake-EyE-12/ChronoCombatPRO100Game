using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : Action
{
    public Strike()
    {
        manaCost = 1;
    }

    public override void OnPlay()
    {
        Debug.Log("Strike Played");
        CombatController.Instance().DealDamageToEnemy(6);
    }
}
