using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PupOpen : MonoBehaviour
{

    public bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //       Debug.DrawRay(transform.position, Vector2.up * .25f, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, .25f);
        //
        if (hit.collider == true)
        {
            Debug.Log(hit.collider.tag);
        }
//
        if (hit == false)
        {
            isOpen = true;
        }
        else
        {

            if (hit.collider.tag != "Powerups")
            {
                isOpen = true;
            }

            if (hit.collider.tag == "Powerups")
            {
                isOpen = false;
            }
        }
    }
}
