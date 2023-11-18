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
    int mana;

    [SerializeField] private ProgressBar healthBar;


    //card stuff 
    [HideInInspector] public Deck playerDeck = new Deck();

    private void Start() {
        playerDeck.currentHand.Add(CardDatabase.Instance().strike);
        
    }

   //items

    void SettingCurrentHand()
    {
        for(int i = 0; i < 3; i++)
        {
            //Currenthand[i] = playerDeck.Draw();

        }

    }

    void PickCard(int i) {

        //going to have to talk more as well
        //Currenthand[i].OnPlay("reee");
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeHealth(int amount) {
        hp += amount;
        healthBar.slider.value = hp;
    }
}
