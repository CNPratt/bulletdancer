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
    public GameObject GODisplay3;
    public GameObject newhiscore;

    public bool waitforRestart;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        waitforRestart = false;
        Vector3 startPoint = new Vector3(-1.5f, 0, 0);
        Quaternion startRoto = Quaternion.Euler(0, 0, 0);
        Instantiate(playerPrefab, startPoint, startRoto);
        pLives = 1;
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
                    GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 2;
                    EndGame();
                }
            }
        }
        
        while(waitforRestart == true)
        {
            if (ScoreManager.totalScore > PlayerPrefs.GetInt("hiScore"))
            {
                newhiscore.GetComponent<Text>().enabled = true;
                PlayerPrefs.SetInt("hiScore", ScoreManager.totalScore);
                Debug.Log(PlayerPrefs.GetInt("hiScore"));
            }

            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                //           Debug.Log("Should restart here");
                Time.timeScale = 1f;
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
                
            }

            if (Input.GetKeyDown(KeyCode.H) == true)
            {

                SceneManager.LoadSceneAsync("Start Screen", LoadSceneMode.Single);
            }

            return;
        }

        void EndGame()
        {
            Time.timeScale = .2f;
            GODisplay.GetComponent<Text>().enabled = true;
            GODisplay2.GetComponent<Text>().enabled = true;
            GODisplay3.GetComponent<Image>().enabled = true;
            waitforRestart = true;
            ComboManager.comboCounter = 0;
            
        }

  //      if(Input.GetKeyDown("p"))
  //      {
  //          GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth = GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth - 100;
  //      }
    }
}
