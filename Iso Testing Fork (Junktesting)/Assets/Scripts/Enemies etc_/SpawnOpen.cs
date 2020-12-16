using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOpen : MonoBehaviour
{
    public LayerMask layermask;
    //spawnsOpen only purpose is to make it easier to represent if there is at least one place to spawn open if using more than 4 spawnpoints
    //for the if() condition of IEnumerator enrollMethod in AltEnemySpawner
    //public static int spawnsOpen;
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

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, .25f, layermask);

        if (hit == false)
        {
  //          Debug.Log("isopen");
            isOpen = true;

        }
        else
        {

            if (hit.collider.tag != "EnemyUnit")
            {
 //               Debug.Log("isopen2");
                isOpen = true;
            }

            if (hit.collider.tag == "EnemyUnit")
            {
//                Debug.Log("isclosed");
                isOpen = false;
            }
        }
    }
}
