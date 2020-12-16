using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public int pHealth;
    public GameObject myText;
    public Text myComponent;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        pHealth = GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth;
        myText = GameObject.Find("Text");
        myComponent = myText.GetComponent<Text>();
        myComponent.text = pHealth.ToString();
    }
}
