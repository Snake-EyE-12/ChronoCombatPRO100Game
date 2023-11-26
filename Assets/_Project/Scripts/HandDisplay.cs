using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HandDisplay : MonoBehaviour
{
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
        // if(player == null) Debug.Log("Player NUll");
        // if(player.playerDeck == null) Debug.Log("Deck NUll");
        // if(player.playerDeck.currentHand == null) Debug.Log("hand NUll");
        if (CombatInfo.Instance().controller.player.playerDeck != null && CombatInfo.Instance().controller.player.playerDeck.currentHand != null && CombatInfo.Instance().controller.player.playerDeck.currentHand.Count != handSize)
        {
            Debug.Log("Hand Display Start");
            xpos = Screen.width / 20;
            for (int j = 0; j < CombatInfo.Instance().controller.player.playerDeck.currentHand.Count; j++)
            {
                if (cards.Count > j) { 
                cards[j] = cardPrefab;
                } else
                {
                    cards.Add(cardPrefab);
                }
                //cards[j] = deck.hand[j].sprite;
            }
            handSize = CombatInfo.Instance().controller.player.playerDeck.currentHand.Count;
            for (int i = 0; i < handSize; i++)
            {
                //(Instantiate(cards[i], new Vector3(xpos, 80, 0), Quaternion.identity) as GameObject).transform.parent = gameObject.transform;
                CardDisplay cd = Instantiate(cards[i], new Vector3(xpos, 80, 0), Quaternion.identity, gameObject.transform).GetComponent<CardDisplay>();
                Debug.Log(CombatInfo.Instance().controller.player.playerDeck.currentHand[i]);
                cd.SetCard(CombatInfo.Instance().controller.player.playerDeck.currentHand[i]);
                xpos += Screen.width / 10;
                ///Test
            }
        }

        //display
 
    }
}
