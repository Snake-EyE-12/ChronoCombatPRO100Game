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
        //enemy = CombatInfo.Instance().enemy;
        //change enemy to random here
        SetEnemy();
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
        CombatInfo.Instance().controller = this;
        player.SettingStartHand();
    }


    private void SetEnemy() {

        int rando = Random.Range(1, 2);

        switch (rando)
        {
            case 1:
                this.enemy = new goblin();
                Resources.Load<Sprite>("goblin idle.png");
                break;
            case 2:
                //switch case for random slime color
                int slimeRandomColor = Random.Range(1, 2);
                switch (slimeRandomColor)
                {
                    case 1:
                        Resources.Load<Sprite>("Sprite Sheet - Blue Idle.png");
                        break;
                    case 2:
                        Resources.Load<Sprite>("Sprite Sheet - Red Idle.png");
                        break;
                    case 3:
                        Resources.Load<Sprite>("Sprite Sheet - Green Idle.png");
                        break;
                }
                this.enemy = new Slime();
                break;
        }

    }
    public void DealDamageToPlayer(int damage) {
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
