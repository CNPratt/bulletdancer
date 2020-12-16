using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonustext : MonoBehaviour
{
    public Text Bonus;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Bonus.text = (ComboManager.bonusFactor * 5).ToString();
    }
}
