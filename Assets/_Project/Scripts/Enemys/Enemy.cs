using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string enemyName;
    public string moveName;

    //basic stats
    public int maxHp = 0;
    public int hp = 0;
    public int def = 0;
    public int atk = 0;

    public void Attack()
    {
        CombatInfo.Instance().controller.DealDamageToPlayer(69);
    }

    #region methods_for_things

    protected int RandomNum(int min, int max)
    {
        int num = Random.Range(min, max);

        return num;
    }
    #endregion
}
