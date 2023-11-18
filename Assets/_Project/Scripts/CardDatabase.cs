using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class CardDatabase : Singleton<CardDatabase>
{
    public Card strike = new Strike();
    public Card fireball = new Fireball();
}
