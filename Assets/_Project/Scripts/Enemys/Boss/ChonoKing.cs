using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChonoKing : Enemy
{
    int squence;
    float powerUp;
    public ChonoKing()
    {
        this.hp = 50;
        this.maxHp = hp;
        this.atk = 12;
        this.def = 12;
    }

    public override void Attack()
    {
        int dmg = 0;
        int move = 0;
        
        if(squence < 5)
        {
            move = RandomNum(1, 2);
            switch (move)
            {
                case 1:
                    dmg = Atk1();
                    break;

                case 2:
                    dmg = Atk2();
                    break;
            }
            squence++;
        }
        else
        {
            squence = 0;
            powerUp += 0.5f;
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
        if(hp < maxHp)
        {
            hp += 15;
        }
        return 0;
    }
    int Atk3()
    {
        moveName = "CHONOBOMB";
        return (int)(atk * powerUp);
    }

    #endregion


}
