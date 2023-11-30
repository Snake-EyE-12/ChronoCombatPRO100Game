using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class EffectController : Singleton<EffectController>
{
    // Hats
    public static bool wizardHat = false;

    // Weapons
    public static bool wizardStaff = false;
    public static bool plasmaSpear = false;
    public static bool ominousRing = false;

    // Armor


    // Cards
    public static bool battleMech = false;
    public static bool gotsaSpeedUp = false;
    public static bool enemyStunned = false;
    public static bool reflect = false;

    // Modifiers
    public static int armorValue = 0;
    public static int manaModifier = 0;
}
