using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PowerWordKill : Spell
{
    public PowerWordKill()
    {
        manaCost = 6;
        castingTime = 3;
    }

    public override void OnPlay()
    {
        Debug.Log("PowerWordKill Played");
        CombatInfo.Instance().player.playerDeck.waitingSpells.Add(this);
    }

    public override void OnEffect()
    {
        castingTime--;
        if (castingTime == 0) CombatInfo.Instance().controller.DealDamageToEnemy(50);
    }
}
