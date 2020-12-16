using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class EnemySpawner : MonoBehaviour
{
    public GameObject tospawnPrefab;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public bool canSpawn;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Tilemap tilemap;
    public float spawnTime;

    public static int totalKills;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 4;
        canSpawn = true;

    }

    // Update is called once per frame
    void Update()
    {
        IEnumerator SpawnEnemy()
        {
//random temp roller
            int roll = (int)Random.Range(1f, 4f);
            if(roll == 1)
            {
 //               Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (roll == 2)
            {
 //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
            if (roll == 3)
            {
//                Debug.Log("3");
                tospawnPrefab = enemy3;
            }

            //
            canSpawn = false;
            if (spawnPoint1.GetComponent<SpawnOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint1.position, spawnPoint1.rotation);
            }
            if (spawnPoint2.GetComponent<SpawnOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint2.position, spawnPoint2.rotation);
            }
            if (spawnPoint3.GetComponent<SpawnOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint3.position, spawnPoint3.rotation);
            }
            if (spawnPoint4.GetComponent<SpawnOpen>().isOpen == true)
            {
                Instantiate(tospawnPrefab, spawnPoint4.position, spawnPoint4.rotation);
            }
                yield return new WaitForSeconds(spawnTime);

            canSpawn = true;
        }

        if (canSpawn == true)
        {
            StartCoroutine(SpawnEnemy());
        }
    }
}
