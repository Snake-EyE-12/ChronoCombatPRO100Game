using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ToyChest : Consumable
{
    public ToyChest()
    {
        manaCost = 3;
    }

    public override void OnPlay()
    {
        List<Card> cards = new List<Card>();
        foreach (Card card in CardDatabase.Instance().cardList)
        {
            if (card.manaCost <= 3 && card.type != "devil")
            {
                cards.Add(card);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            CombatInfo.Instance().controller.player.playerDeck.AddCardHand(cards[Random.Range(0, cards.Count)]);
        }
    }
}
