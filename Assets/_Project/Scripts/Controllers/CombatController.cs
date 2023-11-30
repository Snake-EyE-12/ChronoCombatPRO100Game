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
    private int turnCount;
    static bool addedCards = false;
    private int turn = 1;
    private void Awake()
    {
        CombatInfo.Instance().setCombatInfor();
        player = CombatInfo.Instance().player;
        //enemy = CombatInfo.Instance().enemy;
        //change enemy to random here
        SetEnemy();
        if(!addedCards) {
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().strike);
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
        player.playerDeck.deck.Add(CardDatabase.Instance().fireball);
            player.playerDeck.deck.Add(CardDatabase.Instance().wizardHat);
            player.playerDeck.Shovel();
            addedCards = true;
        }
        CombatInfo.Instance().controller = this;
        player.SettingStartHand();
    }


    private void SetEnemy() {

        int rando = Random.Range(1,3);

        switch (rando)
        {
            case 1:
                this.enemy = new goblin();
                EnemyObject.GetComponent<Animator>().Play("goblinIdle", 0);
                EnemyObject.GetComponent<Transform>().position = new Vector3(5.6f, -1.15f, 6f);

                break;
            case 2:
                //switch case for random slime color
                int slimeRandomColor = Random.Range(1, 4);
                switch (slimeRandomColor)
                {
                    case 1:
                        EnemyObject.GetComponent<Animator>().Play("SlimeBlueIdle", 0);
                        break;
                    case 2:
                        EnemyObject.GetComponent<Animator>().Play("SlimeGreenIdle", 0);
                        break;
                    case 3:
                        EnemyObject.GetComponent<Animator>().Play("SlimeRedIdle", 0);
                        break;
                }
                EnemyObject.GetComponent<Transform>().position = new Vector3(5.6f, -1.5f, 6f);
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
        turnCount++;

        enemy.Attack();
            turn++;
        if (turn < 12)
        {
            player.mana = turn;
        } else
        {
            player.mana = 12;
        }
        player.playerDeck.IncrementCasting();
        player.playerDeck.Draw();
        changeHealthBar();
    }

    public void playCard(Card card, int index)
    {
        if (card.manaCost <= player.mana)
        {
            player.mana -= card.manaCost;
            changeHealthBar();
            card.OnPlay();
            Debug.Log("cards in hand:" + player.playerDeck.currentHand.Count);
            player.playerDeck.DiscardCard(index);
            Debug.Log("cards in hand:" + player.playerDeck.currentHand.Count);
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
