using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Contoller
    //deck class 1. vecotr list 2. methods to controller the class 
    //


    string name;
    int hp;
    int mana;


    //card stuff 
    Deck playerDeck;
    Card[] Currenthand;



   //items

    void SettingCurrentHand()
    {
        for(int i = 0; i < 3; i++)
        {
            Currenthand[i] = playerDeck.Draw();

        }

    }

    void PickCard(int i) {

        //going to have to talk more as well
        Currenthand[i].Play("reee");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
