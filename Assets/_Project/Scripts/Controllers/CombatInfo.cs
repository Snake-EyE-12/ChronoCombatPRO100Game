using Guymon.DesignPatterns;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CombatInfo : Singleton<CombatInfo>
{
    public Player player = new Player();
    public Enemy enemy = new Enemy();
    public CombatController controller;

    public void setCombatInfor()
    {
        player.hp = 40;
        player.maxHp = 40;
        player.mana = 12;
        player.maxMana = 12;
        enemy.hp = 40;
        enemy.maxHp = 40;
    }

}
