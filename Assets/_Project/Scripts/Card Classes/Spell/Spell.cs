using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : Card
{
    public int castingTime;

    public override void OnPlay() { }

    public virtual void OnEffect() { }
}
