using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblin : Enemy
{
    public goblin()
    {
        hp = RandomNum(9,13);
        maxHp = hp;
        def = RandomNum(2, 4);
        atk = RandomNum(3, 6);

    //     public int hp = 0;
    //public int def = 0;
    //public int atk = 0;

}
    void Attack()
    {

        int num = RandomNum(1, 4);
        int dmg = 0;
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
            case 4:
                dmg = Atk4();
                break;
        }

        CombatInfo.Instance().controller.DealDamageToPlayer(dmg);



    }

    #region movesList
    int Atk1()
    {
        moveName = "kick";
        return atk;
    }
    int Atk2()
    {
        moveName = "punch";
        return atk + 1 ;
    }
    int Atk3()
    {
        moveName = "rizz";
        return atk * 0;
    }
    int Atk4()
    {
        //have the name of the move to talk to the controler to display
        moveName = "Hehe";
        return atk * 2;

    }
    #endregion


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
