using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public static int pLives;
    public GameObject playerPrefab;
    public GameObject GODisplay;
    public GameObject GODisplay2;

    public bool waitforRestart;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        waitforRestart = false;
        Vector3 startPoint = new Vector3(-1.5f, 0, 0);
        Quaternion startRoto = Quaternion.Euler(0, 0, 0);
        Instantiate(playerPrefab, startPoint, startRoto);
        pLives = 3;
        GameObject GODisplay = GameObject.Find("GameOverDisplay");
        GODisplay2 = GameObject.Find("Restarttext");
        GODisplay.GetComponent<Text>().enabled = false;
        GODisplay2.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lastTransform = playerPrefab.transform.position;
        Quaternion lastRotation = playerPrefab.transform.rotation;

        if (LifeCoinController.LifeCoinOn == true)
        {
            pLives = pLives + 1;
            LifeCoinController.LifeCoinOn = false;
        }

        if (GameObject.FindGameObjectWithTag("PlayerUnit") == true)
        {
            lastTransform = GameObject.Find("Player(Clone)").GetComponent<Transform>().position;
            lastRotation = GameObject.Find("Player(Clone)").GetComponent<Transform>().rotation;
        }
        if (waitforRestart == false)
        {
            if (GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth <= 0)
            {
                pLives = pLives - 1;
                Destroy(GameObject.Find("Player(Clone)"));
                if (pLives > 0)
                {
                    Instantiate(playerPrefab, lastTransform, lastRotation);
           //         Debug.Log("Player Rezzed!");
                }
                if (pLives <= 0)
                {
                    EndGame();
                }
            }
        }
        
        while(waitforRestart == true)
        {
            if(Input.anyKeyDown == true)
            {
     //           Debug.Log("Should restart here");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1f;
            }
            return;
        }

        void EndGame()
        {
            Time.timeScale = .2f;
            GODisplay.GetComponent<Text>().enabled = true;
            GODisplay2.GetComponent<Text>().enabled = true;
            waitforRestart = true;
            ComboManager.comboCounter = 0;
            
        }
    }
}
