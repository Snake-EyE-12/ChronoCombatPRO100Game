using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public int PlayCard(int mana, Card card)
    {
        if (mana < card.mana) return mana;

        card.Play(card.type);
        return (mana - card.mana);
    }

<<<<<<< Updated upstream



=======
>>>>>>> Stashed changes
};
