using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    public static int comboLevel;
    public static float bonusFactor = 0f;

    public static int comboCounter;
    public int comboTimer;
    public static float comboTimeInt;
    public static bool isCounting = false;
    public static int killsToAdd;

    // Start is called before the first frame update
    void Start()
    {
        comboTimer = 0;
        comboTimeInt = 1.5f;
        comboCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bonusFactor = comboLevel * .2f;
        if (comboCounter < 10)
        {
            comboLevel = 0;
        }
        if (comboCounter >= 10 && comboCounter < 20)
        {
            comboLevel = 1;
        }
        if(comboCounter >= 20 && comboCounter < 30)
        {
            comboLevel = 2;
        }
        if (comboCounter >= 30 && comboCounter < 40)
        {
            comboLevel = 3;
        }
        if (comboCounter >= 40 && comboCounter < 50)
        {
            comboLevel = 4;
        }
        if (comboCounter >= 50 && comboCounter < 60)
        {
            comboLevel = 5;
        }
        if (comboCounter >= 60 && comboCounter < 70)
        {
            comboLevel = 6;
        }
        if (comboCounter >= 70 && comboCounter < 80)
        {
            comboLevel = 7;
        }
        if (comboCounter >= 80 && comboCounter < 90)
        {
            comboLevel = 8;
        }
        if (comboCounter >= 90 && comboCounter < 100)
        {
            comboLevel = 9;
        }
        if (comboCounter >= 100)
        {
            comboLevel = 10;
        }

        bonusFactor = comboLevel * .2f;

        if (killsToAdd > 0)
        {
          //  Debug.Log("kill added");
            StartCoroutine(ComboMethod());
        }

        IEnumerator ComboMethod()
        {
            if (killsToAdd > 0)
            {
         //       Debug.Log("isCounting on");
                killsToAdd = killsToAdd - 1;
                isCounting = true;
                StartCoroutine(Counter());
                yield return new WaitForSeconds(3);
                isCounting = false;
//                Debug.Log("isCounting off");

            }
            else
            yield return null;
        }

        IEnumerator Counter()
        {
            comboCounter = comboCounter + 1;
            comboTimer = comboTimer + 1;
            yield return new WaitForSeconds(comboTimeInt);
            comboTimer = comboTimer - 1;
            if(comboTimer == 0)
            {
             //   Debug.Log("Counter reset");
                comboCounter = 0;
            }
        }
        
    }
}
