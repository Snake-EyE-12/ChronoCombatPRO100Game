using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private ProgressBar healthBar;

    public string enemyName;
    public string moveName;
    //Type???? 


    //basic stats
    public int maxHp;
    public int hp;
    public int def;
    public int atk;

    public void Attack()
    {
        //
        CombatController.Instance().DealDamageToPlayer(69);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void takeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0) die();
        healthBar.slider.value = hp;
    }


    #region methods_for_things
    public void die()
    {

    }


    protected int RandomMove(int min, int max)
    {

        int num = Random.Range(min, max);

        return num;
    }
    #endregion
}
