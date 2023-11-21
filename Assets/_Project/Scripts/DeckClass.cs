using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    List<Card> deck = new List<Card>();
    List<Card> discarded = new List<Card>();
    public List<Card> currentHand = new List<Card>();
    int discradSize = 0;

    void Discarded(int i) {

        //maybe right
        //deck[i].discraded = true;

    }

    void Shovel()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            Card temp = deck[i];
            int rand = Random.Range(0, deck.Count);
            deck[i] = deck[rand];
            deck[rand] = temp;

        }

    }


    public void Draw() {

        currentHand.Add(deck[0]);
        discarded.RemoveAt(0);

    }



    void AddCard()
    {
        //talk with team
    }


    Card SearchForCard(string name)  {

        for(int i = 0; i <= deck.Count; i++)
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
        currentHand.RemoveAt(0);

    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}