using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSenseArray : MonoBehaviour
{
    public int randomspawnRoller;
    public GameObject firstPoint;
    public static GameObject randomOpenPoint;
    public List<GameObject> spawnPoints = new List<GameObject>();
    public static bool isOneOpen = true;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Spawnpoint")
        {
            //Debug.Log("working");
            //Debug.Log(collision.collider.gameObject);

            if (collision.collider.gameObject.GetComponent<SpawnOpen>().isOpen == true)
            {
                if (!spawnPoints.Contains(collision.collider.gameObject))
                {
                    //                   Debug.Log("added" + collision.collider.gameObject);
                    spawnPoints.Add(collision.collider.gameObject);
                }
            }
            if (collision.collider.gameObject.GetComponent<SpawnOpen>().isOpen == false)
            {
                //                Debug.Log("triggered to remove");
                if (spawnPoints.Contains(collision.collider.gameObject))
                {
                    //                    Debug.Log("removed" + collision.collider.gameObject);
                    spawnPoints.Remove(collision.collider.gameObject);
                }
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        randomOpenPoint = firstPoint;
    }

    // Update is called once per frame
    void Update()
    {
        //        Debug.Log(spawnPoints.Count + " " + " " + randomspawnRoller);
        if (spawnPoints.Count == 0)
        { }
        if (spawnPoints.Count != 0)
        {
            randomspawnRoller = Random.Range(0, spawnPoints.Count - 1);


            if (spawnPoints[0] == true)
            {
                isOneOpen = true;
                randomOpenPoint = spawnPoints[randomspawnRoller];
            }
            else
            {
                isOneOpen = false;
            }
        }
    }
}