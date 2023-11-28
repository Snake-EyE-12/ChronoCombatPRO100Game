using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fireball : Spell
{
    public Fireball()
    {
        manaCost = 3;
        castingTime = 1;
    }
    public override void OnPlay()
    {
        Debug.Log("Fireball Played");
        CombatInfo.Instance().player.playerDeck.waitingSpells.Add(this);
    }
    public override void OnEffect()
    {
        castingTime--;
        if (castingTime <= 0)
        {
            CombatInfo.Instance().controller.DealDamageToEnemy(15);
        }
    }
}
