using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int mana;
    public string type;

    public void Cast(string type)
    {
    }
    public void Play(string type)
    {
        switch (type) {
            case "spell":
                break;
            case "item":
                break;
            case "equipment":
                break;
        }

    }
}
