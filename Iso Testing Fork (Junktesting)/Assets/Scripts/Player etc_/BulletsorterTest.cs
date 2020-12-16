using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletsorterTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enWeapon" && collision.name != "Shockorb" && collision.name != "orbspawn(Clone)")
        {
        //    Debug.Log("Entered");
            collision.GetComponent<SortingGroup>().enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "enWeapon")
        {
            //     Debug.Log("Exit");
            if (collision.GetComponent<SortingGroup>() == true)
            {
                collision.GetComponent<SortingGroup>().enabled = false;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
