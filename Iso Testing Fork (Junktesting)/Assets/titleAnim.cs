using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleAnim : MonoBehaviour
{
    public int animStep = 1;
    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject bg4;

    public bool isAnim = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        bg1 = GameObject.Find("MainscreenBG");
        bg2 = GameObject.Find("MainscreenBG (1)");
        bg3 = GameObject.Find("MainscreenBG (2)");
        bg4 = GameObject.Find("MainscreenBG (3)");

        StartCoroutine(animMethod());


        IEnumerator animMethod()
        {
            bg4.SetActive(false);
            bg1.SetActive(true);
            yield return new WaitForSeconds(.2f);

            bg1.SetActive(false);
            bg2.SetActive(true);
            yield return new WaitForSeconds(.2f);

            bg2.SetActive(false);
            bg3.SetActive(true);
            yield return new WaitForSeconds(.2f);

            bg3.SetActive(false);
            bg4.SetActive(true);
            yield return new WaitForSeconds(.2f);

            StartCoroutine(animMethod());
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {

            
    }
}

 