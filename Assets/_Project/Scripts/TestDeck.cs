using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> hand = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        hand.Add(new Card());
        hand.Add(new Card());
        deck.Add(new Card());
        deck.Add(new Card());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}   
