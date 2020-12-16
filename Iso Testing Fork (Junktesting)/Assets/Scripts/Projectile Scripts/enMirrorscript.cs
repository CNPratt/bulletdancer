using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enMirrorscript : MonoBehaviour
{
    public AudioClip reflectSFX;
    public GameObject mirrOwner;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;

    public GameObject bigBull;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.collider.tag == "Weapon")
        {

            if (collision.collider.name == "bulletPrefab(Clone)")
            {
                Object.Destroy(collision.collider.gameObject);
                Instantiate(bullet1, collision.contacts[0].point, transform.rotation);
            }
            if (collision.collider.name == "diagdownbulletPrefab(Clone)")
            {
                Object.Destroy(collision.collider.gameObject);
                Instantiate(bullet2, (collision.contacts[0].point + new Vector2(0, .5f)), bullet2.transform.rotation);
            }
            if (collision.collider.name == "diagupbulletPrefab(Clone)")
            {
                Object.Destroy(collision.collider.gameObject);
                Instantiate(bullet3, collision.contacts[0].point, bullet3.transform.rotation);
            }

            if (collision.collider.name == "bigshotPrefab(Clone)")
            {
                Object.Destroy(collision.collider.gameObject);
                bigBull = Instantiate(bullet1, collision.contacts[0].point, transform.rotation);
            }

            if (collision.collider.name == "bigshotdiagupPrefab(Clone)")
            {
                Object.Destroy(collision.collider.gameObject);
                Instantiate(bullet3, collision.contacts[0].point + new Vector2(0, .1f), bullet3.transform.rotation);
            }

            if (collision.collider.name == "bigshotdiagdownPrefab(Clone)")
            {
                Object.Destroy(collision.collider.gameObject);
                Instantiate(bullet2, collision.contacts[0].point + new Vector2(0, .25f), bullet2.transform.rotation);
            }

            AudioSource.PlayClipAtPoint(reflectSFX, transform.position, .5f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator shieldDestroy()
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            Destroy(gameObject);
            if (mirrOwner == true)
            {
                mirrOwner.GetComponent<Enemy4AI>().haveMirror = false;
            }

        }

        StartCoroutine(shieldDestroy());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
