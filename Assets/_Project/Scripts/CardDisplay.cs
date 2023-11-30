using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private Image cardSprite;
    private int index;
    public void CollectCard() {
        CombatInfo.Instance().player.playerDeck.AddCardDeck(card);
        SceneManager.LoadScene("Map");
    }
    private void Update() {
        if(card != null) cardSprite.sprite = card.sprite;
    }
    public void Play() {
        CombatInfo.Instance().controller.playCard(card, index);
    }
    public void SetCard(Card card)
    {
        Debug.Log("Current Card: " + card);
        this.card = card;
    }
    public void SetCard(Card card, int handposition) {
        Debug.Log("Current Card: " + card);
        this.card = card;
        index = handposition;
        Debug.Log(index);
    }
    public int GetIndex() { return index; }
    public void RemoveSimilarCard() {
        SceneManager.LoadScene("Menu");
    }
}
