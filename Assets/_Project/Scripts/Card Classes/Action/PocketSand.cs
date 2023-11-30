using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PocketSand : Action
{
    public PocketSand()
    {
        manaCost = 1;
    }
    public override void OnPlay()
    {
        EffectController.enemyStunned = true;
    }
}
