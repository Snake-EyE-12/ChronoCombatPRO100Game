using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatController : MonoBehaviour
{
    public Player player;
    public GameObject EnemyObject;
    public Enemy enemy;
    public ProgressBar playerHealth;
    public ProgressBar enemyHealth;
    public ProgressBar playerMana;

    private void Awake()
    {
        CombatInfo.Instance().setCombatInfor();
        player = CombatInfo.Instance().player;
        enemy = CombatInfo.Instance().enemy;
        //change enemy to random here
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
        player.playerDeck.deck.Add(CardDatabase.Instance().powerWordKill);
        player.playerDeck.deck.Add(CardDatabase.Instance().toyChest);
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        CombatInfo.Instance().controller = this;
        player.SettingStartHand();
    }
    public void DealDamageToPlayer(int damage)
    {
        ChangePlayerHealth(-damage);
        changeHealthBar();
    }

    public void endTurn()
    {

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
        DealEnemyDamage(damage);
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

    public void enemyDie()
    {
        if (enemy.hp <= 0)
        {
            player.playerDeck.Shovel();
            SceneManager.LoadScene("CardPicker");
        }
    }
    public void ChangePlayerHealth(int amount)
    {
        player.hp += amount;
        playerHealth.slider.value = player.hp;
        if (player.hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void DealEnemyDamage(int damage)
    {
        enemy.hp -= damage;
        if (enemy.hp <= 0) enemyDie();
        enemyHealth.slider.value = enemy.hp;
    }
}
