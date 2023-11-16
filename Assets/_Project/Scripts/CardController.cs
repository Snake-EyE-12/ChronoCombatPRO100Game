using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    int PlayCard(int mana, Card card)
    {
        if (mana < card.mana) return mana;

        card.Cast();
        return (mana - card.mana);
    }
};
