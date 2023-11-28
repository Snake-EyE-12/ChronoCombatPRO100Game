using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Card
{
    public int manaCost;
    public string type;
    public bool temp;
    public Sprite sprite;

    public virtual void OnPlay()
    {

    }

    public int Cost()
    {
        return manaCost;
    }
}
