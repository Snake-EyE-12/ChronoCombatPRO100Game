using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golm : Enemy
{
    int squene = 0;
    public Golm()
    {
        this.hp = RandomNum(50,69);
        this.atk = RandomNum(10, 15);
        this.def = RandomNum(15, 20);
        maxHp = hp;
     }

    public override void Attack()
    {
        
        int dmg = 0;
        int move = squene % 2;


        switch (move)
        {
            case 0:
                dmg = Atk1();
                break;
            case 1:
                dmg = Atk2();
                break;
        }

        if(squene == 10)
        {
            squene = 0;
            dmg = Atk3();
        }
        squene++;

        CombatInfo.Instance().controller.DealDamageToPlayer(dmg);



    }

    #region movesList
    int Atk1()
    {
       
        return atk;
    }
    int Atk2()
    {
        int hit = RandomNum(1, 100);
        int dmg = 0;
        if(hit < 60)
        {
            dmg = 0;
        }
        else
        {
            dmg = atk + RandomNum(2,8);
        }
        return dmg;
    }
    int Atk3()
    {
        int hit = RandomNum(1, 100);
        int dmg = 0;
        if (hit < 80)
        {
            dmg = 0;
        }
        else
        {
            dmg = (int)(atk * 1.5);
        }
        return dmg;
    }
    
    #endregion



  
    
}

