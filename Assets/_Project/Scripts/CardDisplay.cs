using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private Image cardSprite;
    public void CollectCard() {
        //Find Player
        //Add this card to player
        //Player.AddCard(card)
    }
    private void Update() {
        Debug.Log(card);
        if(card != null) cardSprite.sprite = card.sprite;
    }
    public void Play() {
        card.OnPlay();
    }
    public void SetCard(Card card) {
        Debug.Log("Current Card: " + card);
        this.card = card;
    }
}
