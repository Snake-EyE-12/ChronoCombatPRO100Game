using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotsaSpeedUp : Spell
{
    public GotsaSpeedUp()
    {
        manaCost = 3;
    }

    public override void OnPlay()
    {
        /*
        if (castingTime == 0)
        {
            Deck.Draw(2);
            EffectController.Instance().gotsaSpeedUp = true;
            return;
        }
        castingTime--;
        */
    }
}
