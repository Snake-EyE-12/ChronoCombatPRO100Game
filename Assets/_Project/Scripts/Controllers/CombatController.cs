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
    private int wizardHatCount = 0;
    private void Awake()
    {
        CombatInfo.Instance().setCombatInfor();
        player = CombatInfo.Instance().player;
        //enemy = CombatInfo.Instance().enemy;
        //change enemy to random here
        SetEnemy();
        if (!addedCards)
        {
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


    private void SetEnemy()
    {

        int rando = Random.Range(1, 3);
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        if (MapManager.Instance().levelCount % 5 != 0)
        {
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
<<<<<<< Updated upstream
        } else
        {
            switch(rando) {
                case 1:
                    enemy = new Golm();
                    EnemyObject.GetComponent<Animator>().Play("GolemIdle", 0);
                    break;
                case 2:
                    enemy = new ChonoKing();
                    EnemyObject.GetComponent<Animator>().Play("Idle", 0);
                    break;
=======
        }else
        {
            switch(rando)
            {
                case 1:
                    this.enemy = new Golm
                    break;
                case 2:
                    break;

>>>>>>> Stashed changes
            }
        }

    }
    public void DealDamageToPlayer(int damage)
    {
        if (EffectController.reflect)
        {
            DealDamageToEnemy(damage);
            EffectController.reflect = false;
        }
        else
        {
            ChangePlayerHealth(-damage + EffectController.armorValue);
            changeHealthBar();
        }
    }

    public void endTurn()
    {
        if (EffectController.gotsaSpeedUp) EffectController.gotsaSpeedUp = false;
        if (EffectController.battleMech) DealDamageToEnemy(3);
        enemyDie();

        turnCount++;
        turn++;

        if (!EffectController.enemyStunned)
        {
            enemy.Attack();
        }
        else EffectController.enemyStunned = false;

        if (turn < 12)
        {
            player.mana = turn;
        }
        else
        {
            player.mana = 12;
        }

        player.playerDeck.IncrementCasting();
        player.playerDeck.Draw();
        changeHealthBar();
    }

    public void playCard(Card card, int index)
    {
        if (card.manaCost - EffectController.manaModifier <= player.mana)
        {
            player.mana -= card.manaCost - EffectController.manaModifier;

            if (EffectController.plasmaSpear)
            {
                if (card.type == "action")
                {
                    DealDamageToEnemy(1);
                }
            }

            if (EffectController.wizardHat && card.type == "spell") wizardHatCount++;
            if (wizardHatCount == 3)
            {
                ((Spell)card).OnEffect();
            }
            else
            {
                if (EffectController.ominousRing && card.type == "spell")
                {
                    ((Spell)card).OnEffect();
                    ChangePlayerHealth(-card.manaCost);
                }
                else
                {
                    card.OnPlay();
                }
            }
            changeHealthBar();
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
            EffectController.battleMech = false;
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
            player.playerDeck.Shovel();
            CombatInfo.Instance().player = player;
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
