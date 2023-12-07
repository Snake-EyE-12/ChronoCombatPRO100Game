using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deck
{
    public List<Card> deck = new List<Card>();
    public List<Spell> waitingSpells = new List<Spell>();
    public List<Card> discarded = new List<Card>();
    public List<Card> currentHand = new List<Card>();
    public int discradSize = 0;

    void Discarded(int i)
    {
        //maybe right
        //deck[i].discraded = true;

    }

    public void Shovel()
    {
        int count = discarded.Count;
        for (int i = 0; i < count; i++)
        {
            deck.Add(discarded[0]);
            discarded.RemoveAt(0);
        }
        discarded = new List<Card>();
        count = currentHand.Count;
        for (int i = 0; i < count; i++)
        {
            deck.Add(currentHand[0]);
            currentHand.RemoveAt(0);
        }
        currentHand = new List<Card>();

        count = waitingSpells.Count;
        for (int i = 0; i < count; i++)
        {
            deck.Add(waitingSpells[0]);
            waitingSpells.RemoveAt(0);
        }
        waitingSpells = new List<Spell>();

        for (int i = 0; i < deck.Count; i++)
        {
            Card temp = deck[i];
            int rand = Random.Range(0, deck.Count);
            deck[i] = deck[rand];
            deck[rand] = temp;

        }

    }


    public void Draw()
    {
        if (deck.Count != 0)
        {
            currentHand.Add(deck[0]);
            deck.RemoveAt(0);
        }
    }



    public void AddCardDeck(Card card)
    {
        deck.Add(card);
    }

    public void AddCardHand(Card card)
    {
        currentHand.Add(card);
    }

    Card SearchForCard(string name)
    {

        for (int i = 0; i <= deck.Count; i++)
        {
            // if (deck[i].name == name)
            // {
            //     return deck[i];
            // }

        }
        return null;
    }
    public void removeCardfromHand(int i)
    {
        currentHand.RemoveAt(i);
    }
    public void removeCardfromDeck(int i)
    {
        deck.RemoveAt(i);
    }

    public void DiscardCard(int i)
    {
        discarded.Add(currentHand[i]);
        removeCardfromHand(i);
    }

    public void IncrementCasting()
    {
        foreach (Spell spell in waitingSpells) spell.OnEffect();

        for (int i = 0; i < waitingSpells.Count;)
        {
            if (waitingSpells[i].castingTime <= 0)
            {
                discarded.Add(waitingSpells[i]);
                waitingSpells.Remove(waitingSpells[i]);
            }
            else
            {
                i++;
            }
        }
    }
}