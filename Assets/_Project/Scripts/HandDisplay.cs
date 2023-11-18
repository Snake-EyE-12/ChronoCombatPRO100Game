using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HandDisplay : MonoBehaviour
{
    public TestDeck deck;
    public int handSize;
    public IPanel handContainer;
    List<GameObject> cards;
    int xpos;
    public GameObject cardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        cards = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (deck.hand.Count != handSize)
        {
            xpos = 55;
            for (int j = 0; j < deck.hand.Count; j++)
            {
                if (cards.Count > j) { 
                cards[j] = cardPrefab;
                } else
                {
                    cards.Add(cardPrefab);
                }
                //cards[j] = deck.hand[j].sprite;
            }
            handSize = deck.hand.Count;
            for (int i = 0; i < handSize; i++)
            {
                //(Instantiate(cards[i], new Vector3(xpos, 80, 0), Quaternion.identity) as GameObject).transform.parent = gameObject.transform;
                CardDisplay cd = Instantiate(cards[i], new Vector3(xpos, 80, 0), Quaternion.identity, gameObject.transform).GetComponent<CardDisplay>();
                cd.SetCard(CardDatabase.Instance().strike);
                xpos += 105;
                ///Test
            }
        }

        //display
 
    }
}
