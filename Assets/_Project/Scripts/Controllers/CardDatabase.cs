using System.Collections;
using System.Collections.Generic;
using Guymon.DesignPatterns;
using UnityEngine;

public class CardDatabase : Singleton<CardDatabase>
{
    // Hat
    public Card wizardHat = new WizardHat();

    // Armor

    // Weapon
    public Card ominousRing = new OminousRing();
    public Card plasmaSpear = new PlasmaSpear();
    public Card wizardStaff = new WizardStaff();

    // Consumable 
    public Card healthPotion = new HealthPotion();

    // Spell
    public Card fireball = new Fireball();
    public Card gotsSpeedUp = new GotsaSpeedUp();
    public Card powerWordKill = new PowerWordKill();

    // Action
    public Card battleMech = new BattleMech();
    public Card garson = new Garson();
    public Card pocketSand = new PocketSand();
    public Card strike = new Strike();

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
