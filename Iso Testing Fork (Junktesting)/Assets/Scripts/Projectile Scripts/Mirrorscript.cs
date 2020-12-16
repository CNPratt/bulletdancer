using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirrorscript : MonoBehaviour
{

    public AudioClip reflectSFX;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.collider.tag == "enWeapon")
        {
            //     if(collision.collider.name == "enbulletPrefab(Clone)")
            //      {
            //               Debug.Log(collision.collider.name);

                AudioSource.PlayClipAtPoint(reflectSFX, transform.position, .5f);

                Object.Destroy(collision.collider.gameObject);
                Instantiate(bullet1, collision.contacts[0].point, transform.rotation);
          //  }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
