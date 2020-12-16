using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stupid test script for funsies

public class BulletTimeTest : MonoBehaviour
{
    public Transform bullet1Trans;
    public float bulletDist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float bulletDist = Vector3.Distance(bullet1Trans.position, transform.position);

        enBullet.enbulletSpeed = bulletDist;
    }
}
