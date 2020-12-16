using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTile : MonoBehaviour
{
    public LayerMask layermask;
    public LayerMask orbmask;

    public GameObject targTile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D orbHere = Physics2D.Raycast(transform.position + new Vector3(0f, .5f), new Vector2(1.25f, 0f), .1f, orbmask);

        RaycastHit2D diagExc = Physics2D.Raycast(transform.position + new Vector3(0f, .5f), new Vector2(1.25f, 0f), .7f, layermask);

        RaycastHit2D incBull = Physics2D.Raycast(transform.position + new Vector3(0f, .5f), new Vector2(1.25f, 0f), 1f, layermask);
 //       Debug.DrawRay(transform.position + new Vector3(0f, .5f, 0f), new Vector2(1.25f, 0f) * .8f, Color.green);
        if (incBull == false)
        {
            //Debug.Log("No bullets");
            targTile.GetComponent<SpriteRenderer>().enabled = true;

        }
        if(incBull == true && incBull.collider.tag != "Weapon" && incBull.collider.name != "Bulletsorter")
        {
   //         Debug.Log(incBull.collider.name + " " + incBull.collider.tag);

            if (incBull.collider.name != "dgdEnbulletPrefab(Clone)" && incBull.collider.name != "dguEnbulletPrefab(Clone)")
            {
                //Debug.Log("Bullet inc");
                targTile.GetComponent<SpriteRenderer>().enabled = false;
            }

            if(incBull.collider.name == "dgdEnbulletPrefab(Clone)" || incBull.collider.name == "dguEnbulletPrefab(Clone)")
            {
                if (diagExc.collider == true)
                {

                    if (diagExc.collider.name == "dgdEnbulletPrefab(Clone)" || diagExc.collider.name == "dguEnbulletPrefab(Clone)")
                    {
                        targTile.GetComponent<SpriteRenderer>().enabled = false;
                    }
                }
            }
        }

        if (orbHere == true)
        {
            if (orbHere.collider.name == "Shockorb" || orbHere.collider.name == "orbspawn(Clone)")
            {
                targTile.GetComponent<SpriteRenderer>().enabled = false;
            }
        }

        
    }
}
