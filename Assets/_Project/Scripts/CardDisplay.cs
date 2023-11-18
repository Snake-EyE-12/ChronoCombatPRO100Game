using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private Image cardSprite;
    public void CollectCard() {
        
    }
    private void Update() {
        cardSprite.sprite = card.sprite;
    }
    public void Clicked() {
        card.OnPlay();
    }
    public void SetCard(Card card) {
        this.card = card;
    }
}
