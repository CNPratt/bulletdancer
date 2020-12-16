using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BigshotBullet : MonoBehaviour
{
    public int hits;
    public float bulletSpeed = 3f;
    public Rigidbody2D rb;
    public GameObject impact;
    public GameObject thisImpact;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyUnit")
        {
            thisImpact = Instantiate(impact, transform.position, transform.rotation);
            thisImpact.transform.localScale = new Vector2(2, 2);
            thisImpact.GetComponent<SpriteRenderer>().color = Color.blue;
            hits = hits + 1;

            if (hits > 5)
            {
                
                Destroy(gameObject);
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
