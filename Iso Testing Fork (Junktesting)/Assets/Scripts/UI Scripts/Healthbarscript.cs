using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbarscript : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("health update");
        if (GameObject.Find("Player(Clone)") == true)
        {
            slider.maxValue = GameObject.Find("Player(Clone)").GetComponent<HealthMech>().maxHealth;
            slider.value = GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth;
        }

        if (slider.value >= (slider.maxValue * .7))
        {
            GameObject.Find("Fill").GetComponent<Image>().color = Color.green;
        }

        if (slider.value <= (slider.maxValue * .5))
        {
            GameObject.Find("Fill").GetComponent<Image>().color = Color.yellow;
        }

        if (slider.value <= (slider.maxValue * .25))
        {
            GameObject.Find("Fill").GetComponent<Image>().color = Color.red;
        }
    }
}
