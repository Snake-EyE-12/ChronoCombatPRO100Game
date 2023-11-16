using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    int mana;
    string type;

<<<<<<< Updated upstream
    void Cast(string type)
    {
        switch (type)
            case:
            "spell"
                {

            }
        case:
            "item"
                {
=======

    public void Cast(string type)
    {

        public void Play(string type)
        {

            /*
            switch (type)
                case:
                "spell"
                    {

                }
            case:
                "item"
                    {
>>>>>>> Stashed changes

                }
            case:
                "equipment"
                    {

<<<<<<< Updated upstream
            }
=======
                }
            case:
                "consumable"
                    {

                }
            */
            switch (type)
            {
                case "spell":
                    break;
                case "item":
                    break;
                case "equipment":
                    break;
            }

>>>>>>> Stashed changes
        }
    }
