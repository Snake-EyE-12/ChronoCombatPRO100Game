using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private Image cardSprite;
    public void CollectCard() {
        CombatInfo.Instance().player.playerDeck.AddCardDeck(card);
        SceneManager.LoadScene("Map");
    }
    private void Update() {
        if(card != null) cardSprite.sprite = card.sprite;
    }
    public void Play() {
        CombatInfo.Instance().controller.player.playerDeck.playCard(card);
    }
    public void SetCard(Card card) {
        Debug.Log("Current Card: " + card);
        this.card = card;
    }
    public void RemoveSimilarCard() {
        SceneManager.LoadScene("Menu");
    }
}
