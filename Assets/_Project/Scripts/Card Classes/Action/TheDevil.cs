using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDevil : Action
{
    public override void OnPlay()
    {
        EffectController.reflect = true;
    }
}
