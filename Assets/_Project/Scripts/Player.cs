using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{


    string cardName;
    public int hp = 0;
    public int maxHp = 0;
    public int maxMana = 0;
    public int mana = 0;
    public int turn = 0;

    public Deck playerDeck = new Deck();

    //items

    public void SettingStartHand()
    {
        for (int i = 0; i < 3; i++)
        {
            playerDeck.Draw();

        }

    }

    void PickCard(int i)
    {
    }
}
