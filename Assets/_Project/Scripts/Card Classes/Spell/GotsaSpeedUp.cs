using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GotsaSpeedUp : Spell
{
    public GotsaSpeedUp()
    {
        manaCost = 3;
    }

    public override void OnPlay()
    {

        if (castingTime == 0)
        {
            CombatController.Instance().player.playerDeck.Draw();
            CombatController.Instance().player.playerDeck.Draw();

            EffectController.Instance().gotsaSpeedUp = true;
            return;
        }
        castingTime--;

    }
}
