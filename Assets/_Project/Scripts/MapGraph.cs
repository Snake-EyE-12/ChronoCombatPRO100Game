using Guymon.DesignPatterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapGraph : Singleton<MapGraph>
{
    public Sprite currentSprite;
    public Sprite choice1;
    public Sprite choice2;
    public Sprite treasureSpace;
    public Sprite fightSpace;
    public Sprite HealSpace;
    public Sprite BossSpace;
    public GameObject currentSpace;
    public GameObject space1;
    public GameObject space2;
    public int levelCount;

    public void Start()
    {
        currentSpace.GetComponent<Image>().sprite = currentSprite;
        space1.GetComponent<Image>().sprite = choice1;
        space2.GetComponent<Image>().sprite = choice2;
    }
        
    public void onClick(GameObject space) 
    {
        if (space == space1) {
            currentSprite = choice1;
            
        } else if (space == space2)
        {
            currentSprite = choice2;
        }
        if (currentSprite == fightSpace)
        {
            //load fight
        }
        else if (currentSprite == treasureSpace) {
            //load Treasure
        } else if (currentSprite == HealSpace)
        {
            //load Heal
        } else if (currentSprite == BossSpace)
        {
            //load boss
        }

        createnextChoices(space1);
        createnextChoices(space2);

    }

    public void createnextChoices(GameObject choice)
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                choice.GetComponent<Image>().sprite = fightSpace;
                break;
            case 1:
                choice.GetComponent<Image>().sprite = treasureSpace;
                break;
            case 2:
                choice.GetComponent<Image>().sprite = HealSpace;
                break;
        }
    }
}
