using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggScript : MonoBehaviour
{
    public Toggle toggle;
    public static bool audioOn = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Toggle"))
        {
            toggle = GameObject.Find("Toggle").GetComponent<Toggle>();
        }

        if (toggle != null)
        {
            if (toggle.isOn == true)
            {
                audioOn = true;
                AudioListener.volume = 1;
            }
            if (toggle.isOn == false)
            {
                audioOn = false;
                AudioListener.volume = 0;
            }
        }
        if(toggle == null)
        { }
    }
}
