using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AltEnemySpawner : MonoBehaviour
{
    public GameObject tospawnPrefab;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject treasureBoi;
    public bool canSpawn;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Tilemap tilemap;
    public static float spawnTime;

    public static int totalSpawned;
    public static int totalKills = 1;

    // Start is called before the first frame update
    void Start()
    {
        totalSpawned = 0;
        totalKills = 1;
        spawnTime = 2f;
        canSpawn = true;

    }

    // Update is called once per frame
    void Update()
    {
        //        Debug.Log(spawnTime);
//        Debug.Log(totalKills);
        //Debug.Log("Spawned " + totalSpawned);
        //Debug.Log("Onscreen total " + (totalSpawned - (totalKills - 1)));

        IEnumerator lowEnRefill()
        {
            {
                  yield return new WaitForSeconds(.2f);
     //           if (totalSpawned - (totalKills - 1) <= 5)
                  if(SpawnSenseArray.spawnPoints.Count >= 55)
                {
                    Debug.Log("spawned " + totalSpawned);
                    Debug.Log("killed " + totalKills);
                    //Debug.Log("Low enemies triggered");
                    StartCoroutine(enrollMethodFree());
                }
                yield return null;

            }
        }
        //     if ((totalSpawned - (totalKills - 1) <= 5))
        if (SpawnSenseArray.spawnPoints.Count >= 55)
        {
            StartCoroutine(lowEnRefill());
        }
        //random temp roller
        int enroll = (int)Random.Range(1f, 101f);

        //enemy spawn likelihood split into tiers dependent on currDiffTier

        if (ScoreManager.currentDiffTier == 1)
        {
            if (enroll >= 1 && enroll <= 89)
            {
                //                Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (enroll >= 90 && enroll <= 100)
            {
                //               //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
        }

        if (ScoreManager.currentDiffTier == 2)
        {
            if (enroll >= 1 && enroll <= 80)
            {
                //                Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (enroll >= 81 && enroll <= 94)
            {
                //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
            if (enroll >= 95 && enroll <= 100)
            {
                //                Debug.Log("4");
                tospawnPrefab = treasureBoi;
            }
        }

        if (ScoreManager.currentDiffTier == 3)
        {
            if (enroll >= 1 && enroll <= 70)
            {
                //                Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (enroll >= 71 && enroll <= 85)
            {
                //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
            if (enroll >= 86 && enroll <= 92)
            {
                //                Debug.Log("3");
                tospawnPrefab = enemy3;
            }
            if (enroll >= 93 && enroll <= 100)
            {
                //                Debug.Log("4");
                tospawnPrefab = treasureBoi;
            }
        }
        if (ScoreManager.currentDiffTier == 4)
        {
            if (enroll >= 1 && enroll <= 65)
            {
                //                Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (enroll >= 66 && enroll <= 79)
            {
                //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
            if (enroll >= 80 && enroll <= 85)
            {
                //                Debug.Log("3");
                tospawnPrefab = enemy3;
            }
            if (enroll >= 86 && enroll <= 91)
            {
                //                
                tospawnPrefab = enemy4;
            }
            if (enroll >= 92 && enroll <= 100)
            {
                //                Debug.Log("4");
                tospawnPrefab = treasureBoi;
            }
        }

        if (ScoreManager.currentDiffTier == 5)
        {
            if (enroll >= 1 && enroll <= 55)
            {
                //                Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (enroll >= 56 && enroll <= 66)
            {
                //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
            if (enroll >= 67 && enroll <= 75)
            {
                //                Debug.Log("3");
                tospawnPrefab = enemy3;
            }
            if (enroll >= 76 && enroll <= 81)
            {
                //                
                tospawnPrefab = enemy4;
            }
            if (enroll >= 82 && enroll <= 90)
            {
                //                
                tospawnPrefab = enemy5;
            }
            if (enroll >= 91 && enroll <= 100)
            {
                //                Debug.Log("4");
                tospawnPrefab = treasureBoi;
            }
        }

        if (ScoreManager.currentDiffTier == 6)
        {
            if (enroll >= 1 && enroll <= 45)
            {
                //                Debug.Log("1");
                tospawnPrefab = enemy1;
            }
            if (enroll >= 46 && enroll <= 60)
            {
                //               Debug.Log("2");
                tospawnPrefab = enemy2;
            }
            if (enroll >= 61 && enroll <= 66)
            {
                //                Debug.Log("3");
                tospawnPrefab = enemy3;
            }
            if (enroll >= 67 && enroll <= 75)
            {
                //                
                tospawnPrefab = enemy4;
            }
            if (enroll >= 76 && enroll <= 83)
            {
                //                
                tospawnPrefab = enemy5;
            }
            if (enroll >= 84 && enroll <= 90)
            {
                //                
                tospawnPrefab = enemy6;
            }
            if (enroll >= 91 && enroll <= 100)
            {
                //                Debug.Log("4");
                tospawnPrefab = treasureBoi;
            }
        }

        //end tiers

        IEnumerator enrollMethod()
        {
            
            if (SpawnSenseArray.isOneOpen == true)
            {
                Instantiate(tospawnPrefab, SpawnSenseArray.randomOpenPoint.transform.position, SpawnSenseArray.randomOpenPoint.transform.rotation);
                totalSpawned = totalSpawned + 1;
                yield return new WaitForSeconds(spawnTime);
                canSpawn = true;
                yield return null;
            }
            else
            {
                canSpawn = true;
            }
            yield return null;
        }

        IEnumerator enrollMethodFree()
        {

            if (SpawnSenseArray.isOneOpen == true)
            {
                Instantiate(tospawnPrefab, SpawnSenseArray.randomOpenPoint.transform.position, SpawnSenseArray.randomOpenPoint.transform.rotation);
                totalSpawned = totalSpawned + 1;
                yield return new WaitForSeconds(spawnTime);
                yield return null;

            }
        }

            if (canSpawn == true)
            {
            canSpawn = false;
                StartCoroutine(enrollMethod());
                }
            
        }
    }
