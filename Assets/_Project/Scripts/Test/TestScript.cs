using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Guymon.DesignPatterns;

public class TestScript : Singleton<TestScript>
{
    List<TestScript> myList = new List<TestScript>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
