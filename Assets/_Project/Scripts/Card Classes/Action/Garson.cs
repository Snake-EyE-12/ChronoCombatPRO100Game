using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Garson : Action
{

    public Garson()
    {
        manaCost = 4;
    }
    public override void OnPlay()
    {
        CombatInfo.Instance().controller.DealDamageToEnemy(2);
        EffectController.Instance().reflect = true;
    }
}
