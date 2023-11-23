using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class CardDatabase : Singleton<CardDatabase>
{
    // Hat
    public WizardHat wizardHat = new WizardHat();

    // Armor

    // Weapon
    public OminousRing ominousRing = new OminousRing();
    public PlasmaSpear plasmaSpear = new PlasmaSpear();
    public WizardStaff wizardStaff = new WizardStaff();

    // Consumable 
    public HealthPotion healthPotion = new HealthPotion();

    // Spell
    public Fireball fireball = new Fireball();
    public GotsaSpeedUp gotsSpeedUp = new GotsaSpeedUp();
    public PowerWordKill powerWordKill = new PowerWordKill();

    // Action
    public BattleMech battleMech = new BattleMech();
    public Garson garson = new Garson();
    public PocketSand pocketSand = new PocketSand();
    public Strike strike = new Strike();

    public List<Card> cardList = new List<Card>();

    public void PopulateCardList()
    {
        // Items
        cardList.Add(healthPotion);
        cardList.Add(ominousRing);
        cardList.Add(plasmaSpear);
        cardList.Add(wizardStaff);
        cardList.Add(wizardHat);

        // Spell
        cardList.Add(fireball);
        cardList.Add(gotsSpeedUp);
        cardList.Add(powerWordKill);

        // Action
        cardList.Add(battleMech);
        cardList.Add(garson);
        cardList.Add(pocketSand);
        cardList.Add(strike);
    }
}