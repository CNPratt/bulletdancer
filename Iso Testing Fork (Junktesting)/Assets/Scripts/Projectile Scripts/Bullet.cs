using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impact;
    public float bulletSpeed = 20f;
    public Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyUnit")
        {
            Instantiate(impact, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        impact.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
        rb.velocity = transform.right * bulletSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
