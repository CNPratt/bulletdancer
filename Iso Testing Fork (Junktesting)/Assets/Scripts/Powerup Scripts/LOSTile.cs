using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOSTile : MonoBehaviour
{
    public LayerMask layermask;

    public GameObject losTile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D lineofSight = Physics2D.Raycast(transform.position + new Vector3(0f, .25f), new Vector2(-1.25f, 0f), .25f, layermask);
        Debug.DrawRay(transform.position + new Vector3(0f, .25f, 0f), new Vector2(-1.25f, 0f) * .25f, Color.green);
        if (lineofSight == true)
        {
            if (lineofSight.collider.tag == "SightLine")
            {
                //Debug.Log("In line of sight");
                losTile.GetComponent<SpriteRenderer>().enabled = true;

            }

            if (lineofSight.collider.tag != "SightLine")
            {
                losTile.GetComponent<SpriteRenderer>().enabled = false;
            }
        }

        if(lineofSight.collider == null)
        {
            //Debug.Log("Bullet inc");
            losTile.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
