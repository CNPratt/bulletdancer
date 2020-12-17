using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hiscoreKeeperscript : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("hiScore"))
        {
            text.text = PlayerPrefs.GetInt("hiScore").ToString();
        }

        else if (!PlayerPrefs.HasKey("hiScore"))
        {
            PlayerPrefs.SetInt("hiScore", 0);
            text.text = PlayerPrefs.GetInt("hiScore").ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
