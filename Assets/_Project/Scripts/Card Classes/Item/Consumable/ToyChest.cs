using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyChest : Consumable
{
    public ToyChest()
    {
        manaCost = 3;
    }

    public override void OnPlay()
    {
        // discuss how to implement
        /*
        List<Card> cards = new List<Card>();
        foreach (Card card in CardDatabase.Instance().cardList)
        {
            if (card.mana <= 3)
            {
                cards.Add(card);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            Player.playerHand.Add(cards[Random.Range(0, cards.Count)]);
        }
        */
    }
}
