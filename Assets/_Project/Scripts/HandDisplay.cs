using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HandDisplay : MonoBehaviour
{
    public int handSize;
    public IPanel handContainer;
    List<GameObject> cards;
    List<GameObject> madeCards;
    int xpos;
    int ypos;
    public GameObject cardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        cards = new List<GameObject>();
        madeCards = new List<GameObject>();
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
            xpos = Screen.width / 14;
            ypos = Screen.height / 6;

            for (int j = 0; j < CombatInfo.Instance().controller.player.playerDeck.currentHand.Count; j++)
               {
                if (handSize > j)
                {
                    cards[j] = cardPrefab;
                }
                else
                {
                    cards.Add(cardPrefab);
                }
                //cards[j] = deck.hand[j].sprite;
            }
            for (int j = 0; j < CombatInfo.Instance().controller.player.playerDeck.currentHand.Count;)
            {

                    if (madeCards.Count > j)
                    {
                        madeCards[j].SetActive(false);
                        madeCards.RemoveAt(j);
                    } else
                {
                    j++;
                }
            }
            handSize = CombatInfo.Instance().controller.player.playerDeck.currentHand.Count;
            for (int i = 0; i < handSize; i++)
            {
                madeCards.Add((Instantiate(cards[i], new Vector3(xpos, ypos, 0), Quaternion.identity, gameObject.transform)));
                madeCards[i].SetActive(true);
                //madeCards[i].transform.parent = gameObject.transform;
                //CardDisplay cd = Instantiate(cards[i], new Vector3(xpos, 80, 0), Quaternion.identity, gameObject.transform).GetComponent<CardDisplay>();
                Debug.Log(CombatInfo.Instance().controller.player.playerDeck.currentHand[i]);
                madeCards[i].GetComponent<CardDisplay>().SetCard(CombatInfo.Instance().controller.player.playerDeck.currentHand[i], i);
                xpos += Screen.width / 7;
                ///Test
            }
        }

        //display
 
    }
}
