using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagDownBullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyUnit")
        {
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = (transform.right + (-transform.up / 2)) * bulletSpeed;
        
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
