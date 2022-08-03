using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string hero;
    int health = 70;
    void Start()
    {
        Damage();
        print("The damage rate is: " + Damage());
        health = Damage();
        Boost();
        print("The Boost rate is: " + Boost());

        if (damage() > Boost())
        {
            print(Boost() + " is less than " + damage());
        }
        else if (Boost() > damage())
        {
            print(damage() + " is less than " + Boost());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Damage()
    {
        return health - 20;
    }
    int Boost()
    {
        return health + 10;
    }
    int damage()
    {
        return health;
    }
}
