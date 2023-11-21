using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class CombatController : Singleton<CombatController>
{
    public Player player;
    public Enemy enemy;
    public ProgressBar playerHealth;
    public ProgressBar enemyHealth;
    public ProgressBar playerMana;
    public void DealDamageToPlayer(int damage) {
        player.ChangeHealth(-damage);
        changeHealthBar();
    }
    public void DealDamageToEnemy(int damage)
    {
        enemy.takeDamage(damage);
        changeHealthBar();
        //DealDamageToPlayer(enemy.Attack());
    }
    public void changeHealthBar()
    {
        playerHealth.SetProgress(player.hp, player.maxHp);
        enemyHealth.SetProgress(enemy.hp, enemy.maxHp);

    }
    public void Start()
    {
        changeHealthBar();
    }
}
