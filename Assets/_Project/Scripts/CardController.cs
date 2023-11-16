using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    int PlayCard(int mana, Card card)
    {
        if (mana < card.mana) return mana;

        card.Cast(card.type);
        return (mana - card.mana);
    }


};
