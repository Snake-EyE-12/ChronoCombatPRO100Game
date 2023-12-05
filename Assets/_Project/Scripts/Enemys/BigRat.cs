using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRat : Enemy   
{
    public BigRat()
    {
        hp = RandomNum(7, 9);
        maxHp = hp;
        def = RandomNum(2, 4);
        atk = RandomNum(1, 2);
    }

   public void Actack()
    {
        CombatInfo.Instance().controller.DealDamageToPlayer(RandomNum(1,2) + atk);
    }
   
}
