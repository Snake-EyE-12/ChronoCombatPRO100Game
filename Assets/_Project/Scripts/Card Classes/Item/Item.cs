using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Card
{
    public int slot;
    public Item()
    {
        manaCost = 0;
    }
    public override void OnPlay()
    {

    }

    public virtual void OnEquip()
    {

    }

    public virtual void OnUnequipped()
    {

    }
}
