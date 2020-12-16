using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enhitFlashscript : MonoBehaviour
{
    IEnumerator enhitFlash()
    {
        // Debug.Log("Colorchange");
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        yield return new WaitForSeconds(.05f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        yield return new WaitForSeconds(.05f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        yield return new WaitForSeconds(.05f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enhitFlash());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
