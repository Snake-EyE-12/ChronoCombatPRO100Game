using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Contoller
    //deck class 1. vecotr list 2. methods to controller the class 
    //


    string cardName;
    public int hp;
    public int maxHp;
    public int maxMana;
    public int mana;
    public int turn;

    [SerializeField] private ProgressBar healthBar;
    [SerializeField] private SceneLoader sceneLoader;


    //card stuff 
    [HideInInspector] public Deck playerDeck = new Deck();

    private void Awake()
    {
        playerDeck.deck.Add(CardDatabase.Instance().strike);
        playerDeck.deck.Add(CardDatabase.Instance().fireball);
        playerDeck.deck.Add(CardDatabase.Instance().fireball);
        playerDeck.deck.Add(CardDatabase.Instance().fireball);
        Debug.Log("Cards Added");
        SettingCurrentHand();
    }

    //items

    void SettingCurrentHand()
    {
        for (int i = 0; i < 3; i++)
        {
            playerDeck.Draw();

        }

    }

    void PickCard(int i)
    {
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeHealth(int amount)
    {
        hp += amount;
        healthBar.slider.value = hp;
        if (hp <= 0)
        {
            die();
        }
    }
    private void die()
    {
        sceneLoader.LoadScene();
    }
}
