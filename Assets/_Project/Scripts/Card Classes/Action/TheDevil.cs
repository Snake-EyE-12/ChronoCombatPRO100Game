using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TheDevil : Action
{
    public override void OnPlay()
    {
        EffectController.devil = true;
    }
}
