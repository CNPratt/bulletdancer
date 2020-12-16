using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AltPUPSpawner : MonoBehaviour
{
    public GameObject tospawnPrefab;

    public GameObject melon;
    public GameObject lifecoin;
    public GameObject grapes;
    public GameObject plum;
    public GameObject papple;
    public GameObject kiwi;
    public GameObject orange;
    public GameObject apple;
    public GameObject pear;

    //
    public int treasureLoader;
    //
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
        pupSpawnTime = 10f;
        canSpawn = true;
        treasureLoader = 0;

    }

    // Update is called once per frame
    void Update()
    {
 //       if (treasureLoader == 0)
 //       {
            //random temp roller
            int puproll = (int)Random.Range(1f, 101f);
        if (ComboManager.comboLevel == 0)
        {
            if (puproll >= 1 && puproll <= 30)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 31 && puproll <= 55)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 56 && puproll <= 80)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 81 && puproll <= 90)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 91 && puproll <= 93)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 94 && puproll <= 96)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 97 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;

        }

        if (ComboManager.comboLevel == 1)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 50)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 51 && puproll <= 75)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 76 && puproll <= 87)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 88 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 95)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 96 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;

        }

        if (ComboManager.comboLevel == 2)
        {
            if (puproll >= 1 && puproll <= 24)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 25 && puproll <= 48)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 49 && puproll <= 73)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 74 && puproll <= 85)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 85 && puproll <= 89)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 90 && puproll <= 94)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 95 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;

        }

        if (ComboManager.comboLevel == 3)
        {
            if (puproll >= 1 && puproll <= 24)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 25 && puproll <= 48)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 49 && puproll <= 73)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 74 && puproll <= 85)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 85 && puproll <= 89)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 90 && puproll <= 94)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 95 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;

        }

        if (ComboManager.comboLevel == 4)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 45)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 46 && puproll <= 70)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 71 && puproll <= 81)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 82 && puproll <= 86)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 87 && puproll <= 91)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;

        }

        if (ComboManager.comboLevel == 5)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 42)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 43 && puproll <= 67)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 68 && puproll <= 78)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 79 && puproll <= 83)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 84 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;


        }

        if (ComboManager.comboLevel == 6)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 41)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 42 && puproll <= 65)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 66 && puproll <= 75)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 76 && puproll <= 83)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 84 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 10;

        }
        if (ComboManager.comboLevel == 7)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 41)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 42 && puproll <= 65)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 66 && puproll <= 75)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 76 && puproll <= 83)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 84 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 9;

        }

        if (ComboManager.comboLevel == 8)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 41)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 42 && puproll <= 65)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 66 && puproll <= 75)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 76 && puproll <= 83)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 84 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 8;

        }

        if (ComboManager.comboLevel == 9)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 41)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 42 && puproll <= 65)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 66 && puproll <= 75)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 76 && puproll <= 83)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 84 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 7;

        }

        if (ComboManager.comboLevel == 10)
        {
            if (puproll >= 1 && puproll <= 25)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 26 && puproll <= 41)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 42 && puproll <= 65)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 66 && puproll <= 75)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 76 && puproll <= 83)
            {
                tospawnPrefab = apple;
            }
            if (puproll >= 84 && puproll <= 91)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 92 && puproll <= 100)
            {
                tospawnPrefab = pear;
            }

            pupSpawnTime = 6;

        }

        IEnumerator rollMethod()
        {
            canSpawn = false;
            int roll = (int)Random.Range(1f, 5f);

//            Debug.Log("Rollmethod started!");
         //   Debug.Log(roll);

            if (spawnPoint1.GetComponent<PupOpen>().isOpen || spawnPoint2.GetComponent<PupOpen>().isOpen || spawnPoint3.GetComponent<PupOpen>().isOpen || spawnPoint4.GetComponent<PupOpen>().isOpen)
            {
//                Debug.Log("rolling");

                if (roll == 1)
                {
                    if (spawnPoint1.GetComponent<PupOpen>().isOpen == true)
                    {
                        puproll = (int)Random.Range(1f, 101f);
                        Instantiate(tospawnPrefab, spawnPoint1.position, spawnPoint1.rotation);
                    }
                    else
                    {
                    //    Debug.Log("Reroll initiated");

                        StopCoroutine(rollMethod());
                        StartCoroutine(rollMethod());
                    }
                }
                if (roll == 2)
                {
                    if (spawnPoint2.GetComponent<PupOpen>().isOpen == true)
                    {
                        puproll = (int)Random.Range(1f, 101f);
                        Instantiate(tospawnPrefab, spawnPoint2.position, spawnPoint1.rotation);
                    }
                    else
                    {
                    //    Debug.Log("Reroll initiated");

                        StopCoroutine(rollMethod());
                        StartCoroutine(rollMethod());
                    }
                }
                if (roll == 3)
                {
                    if (spawnPoint3.GetComponent<PupOpen>().isOpen == true)
                    {
                        puproll = (int)Random.Range(1f, 101f);
                        Instantiate(tospawnPrefab, spawnPoint3.position, spawnPoint1.rotation);
                    }
                    else
                    {
                    //    Debug.Log("Reroll initiated");

                        StopCoroutine(rollMethod());
                        StartCoroutine(rollMethod());
                    }
                }
                if (roll == 4)
                {
                    if (spawnPoint4.GetComponent<PupOpen>().isOpen == true)
                    {
                        puproll = (int)Random.Range(1f, 101f);
                        Instantiate(tospawnPrefab, spawnPoint4.position, spawnPoint1.rotation);
                    }
                    else
                    {
                    //    Debug.Log("Reroll initiated");

                        StopCoroutine(rollMethod());
                        StartCoroutine(rollMethod());
                    }
                }

                yield return new WaitForSeconds(pupSpawnTime);
                canSpawn = true;


            }
            canSpawn = true;
        }

        //rollMethod without canSpawn check
        IEnumerator treasureMethod()
        {

            int roll = (int)Random.Range(1f, 5f);

//               Debug.Log("Treasuremethod started!");
            //   Debug.Log(roll);

            if (spawnPoint1.GetComponent<PupOpen>().isOpen || spawnPoint2.GetComponent<PupOpen>().isOpen || spawnPoint3.GetComponent<PupOpen>().isOpen || spawnPoint4.GetComponent<PupOpen>().isOpen)
            {
                //                Debug.Log("rolling");

                if (roll == 1)
                {
                    if (spawnPoint1.GetComponent<PupOpen>().isOpen == true)
                    {
// untested/unproven intended to minimize simultaneous treasureload spawns
// overlapping on a given spawnpoint when all points are full and one is opened
 //                       yield return new WaitForSeconds(.1f + (Random.Range(0f, 1f)/2));
 //                       if (spawnPoint1.GetComponent<PupOpen>().isOpen == true)
   //                     {
                            // if this last if statement is troublesome remove waitforsecond and the curlybrackets/if
                            //leave these two original lines per roll
                            treasureLoader = treasureLoader - 1;
                            Instantiate(tospawnPrefab, spawnPoint1.position, spawnPoint1.rotation);
                            //
 //                       }
                    }
                    else
                    {
                        //    Debug.Log("Reroll initiated");

                        StopCoroutine(treasureMethod());
                        StartCoroutine(treasureMethod());
                    }
                }
                if (roll == 2)
                {
                    if (spawnPoint2.GetComponent<PupOpen>().isOpen == true)
                    {
       //                 yield return new WaitForSeconds(.1f + (Random.Range(0f, 1f) / 2));
       //                 if (spawnPoint2.GetComponent<PupOpen>().isOpen == true)
       //                 {
                            treasureLoader = treasureLoader - 1;
                            Instantiate(tospawnPrefab, spawnPoint2.position, spawnPoint1.rotation);
       //                 }
                    }
                    else
                    {
                        //    Debug.Log("Reroll initiated");

                        StopCoroutine(treasureMethod());
                        StartCoroutine(treasureMethod());
                    }
                }
                if (roll == 3)
                {
                    if (spawnPoint3.GetComponent<PupOpen>().isOpen == true)
                    {
      //                 yield return new WaitForSeconds(.1f + (Random.Range(0f, 1f) / 2));
      //                  if (spawnPoint3.GetComponent<PupOpen>().isOpen == true)
       //                 {
                            treasureLoader = treasureLoader - 1;
                            Instantiate(tospawnPrefab, spawnPoint3.position, spawnPoint1.rotation);
       //                 }
                    }
                    else
                    {
                        //    Debug.Log("Reroll initiated");

                        StopCoroutine(treasureMethod());
                        StartCoroutine(treasureMethod());
                    }
                }
                if (roll == 4)
                {
                    if (spawnPoint4.GetComponent<PupOpen>().isOpen == true)
                    {
   //                     yield return new WaitForSeconds(.1f + (Random.Range(0f, 1f) / 2));
     //                   if (spawnPoint4.GetComponent<PupOpen>().isOpen == true)
       //                 {
                            treasureLoader = treasureLoader - 1;
                            Instantiate(tospawnPrefab, spawnPoint4.position, spawnPoint1.rotation);
         //               }
                    }
                    else
                    {
                        //    Debug.Log("Reroll initiated");

                        StopCoroutine(treasureMethod());
                        StartCoroutine(treasureMethod());
                    }
                }
                yield return null;
         //       Debug.Log("Treasuremethod resolved");
            }
        }
        //end rollmethod copy

        if (canSpawn == true)
        {
            StartCoroutine(rollMethod());
        }
//
         if(treasureLoader > 0)
            {
           //  Debug.Log("Treasureload resolved");
// early melon guaruntee             tospawnPrefab = melon;
             StartCoroutine(treasureMethod());
            //treasureLoader = treasureLoader - 1;
        }
       
    }
}
