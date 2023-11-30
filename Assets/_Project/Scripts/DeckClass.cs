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
        for (int i = 0; i < discarded.Count; i++)
        {
            deck.Add(discarded[i]);
            discarded.RemoveAt(i);
        }
        discarded = new List<Card>();

        for (int i = 0; i < currentHand.Count; i++)
        {
            deck.Add(currentHand[i]);
            currentHand.RemoveAt(i);
        }
        currentHand = new List<Card>();

        for (int i = 0; i < waitingSpells.Count; i++)
        {
            deck.Add(waitingSpells[i]);
            waitingSpells.RemoveAt(i); 
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


    public void DiscardCard(int i)
    {
        discarded.Add(currentHand[i]);
        currentHand.RemoveAt(i);
    }

    public void IncrementCasting()
    {
        foreach (Spell spell in waitingSpells)
        {
            spell.OnEffect();


        }
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