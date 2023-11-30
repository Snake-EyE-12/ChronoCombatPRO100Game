using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class EffectController : Singleton<EffectController>
{
    // Hats
    public bool wizardHat = false;

    // Weapons
    public bool wizardStaff = false;
    public bool plasmaSpear = false;
    public bool ominousRing = false;

    // Armor


    // Cards
    public bool gotsaSpeedUp = false;
    public bool battleMech = false;
    public bool enemyStunned = false;
    public bool reflect = false;
    public bool pocketSand = false;

    // Modifiers
    public int castCost = 0;
    public int armorValue = 0;
}
