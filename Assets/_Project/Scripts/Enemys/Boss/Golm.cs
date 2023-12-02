using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golm : Enemy
{
    public Golm()
    {
        this.hp = RandomNum(50,69);
        this.atk = RandomNum(10, 15);
        this.def = RandomNum(15, 20);
     }

    public override void Attack()
    {
        int squene = 0;
        int dmg = 0;
        int move = squene % 2;

        squene++;

        switch (move)
        {
            case 0:
                dmg = Atk1();
                break;
            case 2:
                dmg = Atk2();
                break;
        }

        if(squene == 10)
        {
            dmg = Atk3();
        }

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

