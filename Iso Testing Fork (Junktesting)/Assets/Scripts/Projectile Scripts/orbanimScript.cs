using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class orbanimScript : MonoBehaviour
{
    public bool orbToggle = false;
    public GameObject deathAnim;
    public GameObject instAnim;

//    private void OnDestroy()
//    {
//        if (ScoreManager.quitOn == true)
//        { return; }
//        else
//        {
//            Instantiate(deathAnim, transform.position, transform.rotation);
//        }
//
    // Start is called before the first frame update
    void Start()
    {

        GameObject newOrb = Instantiate(instAnim, transform.position, transform.rotation);
      newOrb.GetComponent<orbToggler>().orb = gameObject;

        IEnumerator orbDestro()
        {
            yield return new WaitForSeconds(2f);
            Instantiate(deathAnim, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        StartCoroutine(orbDestro());

    }

    // Update is called once per frame
    void Update()
    {
       if(orbToggle == true)
        {
            gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
