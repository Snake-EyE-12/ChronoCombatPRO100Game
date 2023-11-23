using Guymon.DesignPatterns;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MapManager : Singleton<MapManager>
{
    public Sprite[] sprite = new Sprite[3];
    public int levelCount;

    public void setManager(Sprite current, Sprite choice1, Sprite choice2, int levelCount)
    {
        sprite[0] = current;
        sprite[1] = choice1;
        sprite[2] = choice2;
        this.levelCount = levelCount;
    }

}
