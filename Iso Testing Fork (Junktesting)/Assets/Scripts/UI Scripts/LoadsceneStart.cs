using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadsceneStart : MonoBehaviour
{
    public int helpOn;
    public GameObject infOne;
    public GameObject infTwo;
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && helpOn == 0)
        {
            SceneManager.LoadSceneAsync("Gameplay Scene");
        }

        if (Input.GetKeyDown("h") == true && helpOn == 0)
        {
            infOne.SetActive(true);
            helpOn++;
        }

        else if (Input.anyKeyDown == true && helpOn == 1)
        {
            infOne.SetActive(false);
            infTwo.SetActive(true);
            helpOn++;
        }

        else if (Input.anyKeyDown == true && helpOn == 2)
        {
            infOne.SetActive(false);
            infTwo.SetActive(false);
            helpOn = 0;
        }


    }
}
