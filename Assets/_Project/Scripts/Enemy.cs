using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private ProgressBar healthBar;

    public string enemyName;
    //Type???? 


    //basic stats
    public int maxHp;
    public int hp;
    int def;
    int atk;
    
    public int Attack() {
        //
        int r = 1;

        switch (r)
        {
            case 1: return Punch();
                break;

            case 2: 
            return LowBlow();
             break;
        }

        return -1;
    }

    int Punch() {
        return atk + 1;
    }

    int LowBlow() {
        return 10000000;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(int damage) {
        hp -= damage;
        if(hp <= 0) die();
        healthBar.slider.value = hp;
    }
    public void die() {

    }
}
