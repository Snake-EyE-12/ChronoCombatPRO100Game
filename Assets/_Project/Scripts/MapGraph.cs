using Guymon.DesignPatterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapGraph : MonoBehaviour
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
        if (MapManager.Instance().sprite[0] != null)
        {
            currentSprite = MapManager.Instance().sprite[0];
            choice1 = MapManager.Instance().sprite[1];
            choice2 = MapManager.Instance().sprite[2];
            levelCount = MapManager.Instance().levelCount;
        }
        if (MapManager.Instance().levelCount == 0)
        {
            currentSprite = HealSpace;
            choice1 = fightSpace;
            choice2 = fightSpace;
        }
    }
    public void Update()
    {
        currentSpace.GetComponent<Image>().sprite = currentSprite;
        space1.GetComponent<Image>().sprite = choice1;
        space2.GetComponent<Image>().sprite = choice2;
    }
        
    public void onClick(GameObject space) 
    {
        AudioManager.play("Click", false);
        if (space == space1) {
            currentSprite = choice1;
            
        } else if (space == space2)
        {
            currentSprite = choice2;
        }

        choice1 = createnextChoices();
        choice2 = createnextChoices();

        MapManager.Instance().setManager(currentSprite, choice1, choice2, levelCount);

        if (currentSprite == fightSpace)
        {
            SceneManager.LoadScene("Game");
        }
        else if (currentSprite == treasureSpace) {
            //load Treasure
        } else if (currentSprite == HealSpace)
        {
            //load Heal
        } else if (currentSprite == BossSpace)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public Sprite createnextChoices()
    {
        if ((MapManager.Instance().levelCount + 2) % 5 != 0 || MapManager.Instance().levelCount == 0)
        {
            switch (Random.Range(0, 1))
            {
                case 0:
                    return fightSpace;
                case 1:
                    return treasureSpace;
                case 2:
                    return HealSpace;
            }
        } else
        {
            return BossSpace;
        }
        return null;
    }
}
