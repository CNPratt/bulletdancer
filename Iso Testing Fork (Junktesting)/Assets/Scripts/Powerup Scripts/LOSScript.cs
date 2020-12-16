using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOSScript : MonoBehaviour
{
    public GameObject lineofSight;
    // Start is called before the first frame update
    void Start()
    {
        GameObject myLOS;
        myLOS = Instantiate(lineofSight, transform.position, transform.rotation);
        myLOS.transform.parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
