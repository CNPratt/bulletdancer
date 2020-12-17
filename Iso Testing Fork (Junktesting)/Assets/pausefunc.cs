using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pausefunc : MonoBehaviour
{
    public static bool pauseOn;

    public GameObject pauseScreen;
    public GameObject pauseText;

    // Start is called before the first frame update
    void Start()
    {
        pauseOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseOn == false)
            {
                Time.timeScale = 0;
                pauseOn = true;
                pauseScreen.GetComponent<Image>().enabled = true;
                pauseText.GetComponent<Text>().enabled = true;
            }

            else if(pauseOn == true)
            {
                Time.timeScale = 1;
                pauseOn = false;
                pauseScreen.GetComponent<Image>().enabled = false;
                pauseText.GetComponent<Text>().enabled = false;
            }
        }

        if(pauseOn == true && Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadSceneAsync("Start Screen", LoadSceneMode.Single);
        }

    }
}
