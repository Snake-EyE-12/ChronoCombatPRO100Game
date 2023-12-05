using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yordal : Enemy
{

    public Yordal()
    {
        hp = RandomNum(13, 15);
        atk = RandomNum(3, 11);
        def = 4;
    }

    public override void Attack()
    {
        int dmg = 0;
        int num = RandomNum(1, 4);
       
        switch (num)
        {
            case 1:
                dmg = Atk1();
                break;
            case 2:
                dmg = Atk2();
                break;
            case 3:
                dmg = Atk3();
                break;
           
        }

        CombatInfo.Instance().controller.DealDamageToPlayer(dmg);



    }

    #region movesList
    int Atk1()
    {
        return RandomNum(1, 2) + atk;
     
    }
    int Atk2()
    {
        return RandomNum(0, 2) * atk;
    }
    int Atk3()
    {
        hp += 4;
        return 0;
    }

    #endregion

}
