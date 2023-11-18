using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class CombatController : Singleton<CombatController>
{
    public Player player;
    public Enemy enemy;
    public void DealDamageToPlayer(int damage) {
        player.ChangeHealth(-damage);
        
    }
}
