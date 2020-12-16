using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifenumber : MonoBehaviour
{
    public Text lives;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = LifeManager.pLives.ToString();
    }
}
