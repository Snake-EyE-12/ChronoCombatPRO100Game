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
        cardSprite.sprite = card.sprite;
    }
    public void Play() {
        CombatController.Instance().playCard(card);
    }
    public void SetCard(Card card) {
        this.card = card;
    }
}
