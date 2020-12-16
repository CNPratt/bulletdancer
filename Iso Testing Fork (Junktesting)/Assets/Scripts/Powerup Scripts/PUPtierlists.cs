using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPtierlists : MonoBehaviour
{
    public static List<GameObject> tier0PUPs = new List<GameObject>();
    public static List<GameObject> tier1PUPs = new List<GameObject>();
    public static List<GameObject> tier2PUPs = new List<GameObject>();
    public static List<GameObject> tier3PUPs = new List<GameObject>();
    public static List<GameObject> tier4PUPs = new List<GameObject>();
    public static List<GameObject> tier5PUPs = new List<GameObject>();
    public static List<GameObject> tier6PUPs = new List<GameObject>();
    public GameObject kiwi;
    public GameObject plum;
    public GameObject melon;
    public GameObject grapes;
    public GameObject orange;
    public GameObject papple;
    public GameObject lifecoin;
    public GameObject tospawnPrefab;


    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tier0PUPs = {kiwi, melon, papple};
        GameObject[] tier1PUPs = {kiwi, melon, papple};
        GameObject[] tier2PUPs = {kiwi, melon, papple};
        GameObject[] tier3PUPs = {kiwi, melon, papple};
        GameObject[] tier4PUPs = {kiwi, melon, papple};
        GameObject[] tier5PUPs = {kiwi, melon, papple};
        GameObject[] tier6PUPs = {kiwi, melon, papple};

    }

    // Update is called once per frame
    void Update()
    {
        int puproll = (int)Random.Range(1f, 101f);
        if (ComboManager.comboLevel == 0)
        {
            if (puproll >= 1 && puproll <= 34)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 35 && puproll <= 67)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 68 && puproll <= 100)
            {
                tospawnPrefab = kiwi;
            }
        }

        if (ComboManager.comboLevel == 1)
        {
            if (puproll >= 1 && puproll <= 34)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 35 && puproll <= 67)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 68 && puproll <= 100)
            {
                tospawnPrefab = kiwi;
            }
        }

        if (ComboManager.comboLevel == 2)
        {
            if (puproll >= 1 && puproll <= 24)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 25 && puproll <= 49)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 50 && puproll <= 74)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 75 && puproll <= 100)
            {
                tospawnPrefab = papple;
            }
        }

        if (ComboManager.comboLevel == 3)
        {
            if (puproll >= 1 && puproll <= 19)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 20 && puproll <= 39)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 40 && puproll <= 59)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 60 && puproll <= 79)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 80 && puproll <= 100)
            {
                tospawnPrefab = grapes;
            }
        }

        if (ComboManager.comboLevel == 4)
        {
            if (puproll >= 1 && puproll <= 19)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 20 && puproll <= 39)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 40 && puproll <= 59)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 60 && puproll <= 79)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 80 && puproll <= 100)
            {
                tospawnPrefab = grapes;
            }
        }

        if (ComboManager.comboLevel == 5)
        {
            if (puproll >= 1 && puproll <= 17)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 18 && puproll <= 35)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 36 && puproll <= 53)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 54 && puproll <= 71)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 72 && puproll <= 90)
            {
                tospawnPrefab = grapes;
            }
            if (puproll >= 91 && puproll <= 100)
            {
                tospawnPrefab = plum;
            }

        }

        if (ComboManager.comboLevel == 6)
        {
            if (puproll >= 1 && puproll <= 17)
            {
                tospawnPrefab = melon;
            }
            if (puproll >= 18 && puproll <= 35)
            {
                tospawnPrefab = orange;
            }
            if (puproll >= 36 && puproll <= 53)
            {
                tospawnPrefab = kiwi;
            }
            if (puproll >= 54 && puproll <= 71)
            {
                tospawnPrefab = papple;
            }
            if (puproll >= 72 && puproll <= 90)
            {
                tospawnPrefab = grapes;
            }
            if (puproll >= 91 && puproll <= 97)
            {
                tospawnPrefab = plum;
            }
            if (puproll >= 98 && puproll <= 100)
            {
                tospawnPrefab = lifecoin;
            }
        }
    }
}
