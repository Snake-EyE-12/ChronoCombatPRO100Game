using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public string name;
    //Type???? 


    //basic stats
     int hp;
    int def;
    int atk;
    
    int Attack() {
        //
        int r = 2;

        switch (r)
        {
            case 1: Punch();
                break;

            case 2: 
            LowBlow();
             break;
        }

        return -1;
    }

    int Punch() {
        return atk + 1;
    }

    int LowBlow() {
        return 10000000;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
