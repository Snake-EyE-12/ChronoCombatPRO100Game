using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GotsaSpeedUp : Spell
{
    public GotsaSpeedUp()
    {
        manaCost = 3;
        castingTime = 1;
    }
    public override void OnPlay()
    {
        Debug.Log("GotsaSpeedUp Played");
        CombatInfo.Instance().controller.player.playerDeck.waitingSpells.Add(this);
    }
    public override void OnEffect()
    {
        castingTime--;
        if (castingTime == 0)
        {
            CombatInfo.Instance().controller.player.playerDeck.Draw();
            CombatInfo.Instance().controller.player.playerDeck.Draw();

            CombatController.manaModifier++;
            CombatController.gotsaSpeedUp = true;
        }
    }
}
