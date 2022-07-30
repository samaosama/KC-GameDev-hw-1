using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    string heroName = "Sama";
    float heroHeight = 1.64f;
    int heroAge = 14;
    string heroSuperPower = "Invisability";

    string villainName = "Sally";
    float villainHeight = 1.55f;
    int villainAge = 12;
    string villainSuperPower = "None";
    void Start()
    {
        int ageDifference = heroAge - villainAge;
        heroHeight = heroHeight + 5;
        print("The hero's name is " + heroName + ", And the villain's name is " + villainName);
        print("The hero's height is " + heroHeight + ", And the villain's hight is " + villainHeight);
        print("The hero's age is " + heroAge + ", And the villain's age is " + villainAge);
        print("The hero's Super Power is " + heroSuperPower + ", And the villain's Super Power is " + villainSuperPower);
        print("The age difference between the Hero and the Villain is " + ageDifference);
    }

}
