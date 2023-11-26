using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fireball : Spell
{

    public Fireball()
    {
        manaCost = 3;
    }
    public override void OnPlay()
    {
        Debug.Log("Fireball Played");
        CombatController.Instance().DealDamageToPlayer(15);

        if (castingTime == 0)
        {
            CombatController.Instance().DealDamageToEnemy(15);
        }
        castingTime--;

    }
}
