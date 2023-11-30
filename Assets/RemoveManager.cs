using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveManager : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;
    public RectTransform content;
    public float size;

    
    List<Card> allCardsInDeck = new List<Card>();

    private void Awake() {
        

    }
    private void Start() {
        allCardsInDeck.AddRange(CombatInfo.Instance().player.playerDeck.deck);
        allCardsInDeck.AddRange(CombatInfo.Instance().player.playerDeck.currentHand);
        foreach(Card card in allCardsInDeck) {
            CardDisplay display = Instantiate(prefab, parent).GetComponent<CardDisplay>();
            display.SetCard(card);
        }
        content.sizeDelta = new Vector3(content.sizeDelta.x, ((allCardsInDeck.Count + 3) / 3.0f) * size);
        content.position = Vector3.zero;
    }
    

}
