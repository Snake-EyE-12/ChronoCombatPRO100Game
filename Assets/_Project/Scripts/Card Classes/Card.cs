using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public int mana;
    public string type;
    public Sprite sprite;

    public virtual void OnPlay()
    {

    }
}
