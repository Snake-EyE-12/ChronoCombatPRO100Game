using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BattleMech : Action
{
    public BattleMech()
    {
        manaCost = 3;
    }
    public override void OnPlay()
    {
        EffectController.battleMech = true;
    }
}
