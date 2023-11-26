using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblin : Enemy
{

    void Attack()
    {

        int num = RandomMove(1, 4);
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
    #region movesList
    int Atk1()
    {
        moveName = "kick";
        return 5;
    }
    int Atk2()
    {
        moveName = "punch";
        return 10;
    }
    int Atk3()
    {
        moveName = "rizz";
        return 15;
    }
    int Atk4()
    {
        //have the name of the move to talk to the controler to display
        moveName = "Hehe";
        return 69;

    }
    #endregion
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