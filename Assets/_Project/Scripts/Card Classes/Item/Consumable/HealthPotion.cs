using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealthPotion : Consumable

{
    public HealthPotion()
    {
        manaCost = 2;
    }

    public override void OnPlay()
    {
        CombatController.Instance().player.ChangeHealth(10);
        //Deck.Remove();
    }
}
