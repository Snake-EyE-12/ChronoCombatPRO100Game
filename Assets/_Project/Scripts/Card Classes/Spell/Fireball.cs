using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        /*
        if (castingTime == 0)
        {
        Controller.DealDmg(15);
        }
        castingTime--;
        */
    }
}
