using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void playCard(Card card)
    {
        if (card.manaCost < player.mana)
        {
            player.mana -= card.manaCost;
            card.OnPlay();
        }
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
        playerMana.SetProgress(player.mana, player.maxMana);
    }
    public void Start()
    {
        changeHealthBar();

        
    }

    public void Update()
    {
        if (enemy.hp <= 0)
        {

            SceneManager.LoadScene("CardPicker");
        }
    }
}
