using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject tospawnPrefab;

    public GameObject melon;
    public GameObject lifecoin;
//    public GameObject grapes;
    public GameObject plum;
    public GameObject papple;
    public GameObject kiwi;
    public GameObject orange;

    public bool canSpawn;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Tilemap tilemap;
    public float pupSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        pupSpawnTime = 10;
        canSpawn = true;

    }

    // Update is called once per frame
    void Update()
    {
        IEnumerator SpawnPup()
        {
            //random temp roller
            int roll = (int)Random.Range(1f, 91f);
            if (roll >= 1 && roll <=15)
            {
    //            Debug.Log("1");
                tospawnPrefab = melon;
            }
            if (roll >= 16 && roll <= 30)
            {
    //            Debug.Log("2");
                tospawnPrefab = orange;
            }
            if (roll >= 31 && roll <= 45)
            {
   //             Debug.Log("3");
                tospawnPrefab = kiwi;
            }
            if (roll >= 46 && roll <= 60)
            {
    //            Debug.Log("4");
                tospawnPrefab = papple;
            }
            if (roll >= 61 && roll <= 75)
            {
    //            Debug.Log("5");
                tospawnPrefab = plum;
            }
            if (roll >= 76 && roll <= 90)
            {
   //             Debug.Log("6");
                tospawnPrefab = lifecoin;
            }

            //
            canSpawn = false;
            if (spawnPoint1.GetComponent<PupOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint1.position, spawnPoint1.rotation);
            }
            if (spawnPoint2.GetComponent<PupOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint2.position, spawnPoint2.rotation);
            }
            if (spawnPoint3.GetComponent<PupOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint3.position, spawnPoint3.rotation);
            }
            if (spawnPoint4.GetComponent<PupOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint4.position, spawnPoint4.rotation);
            }
            yield return new WaitForSeconds(pupSpawnTime);

            canSpawn = true;
        }

        if (canSpawn == true)
        {
            StartCoroutine(SpawnPup());
        }
    }
}
