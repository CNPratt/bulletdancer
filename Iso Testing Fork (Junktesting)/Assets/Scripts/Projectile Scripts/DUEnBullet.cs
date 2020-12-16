using UnityEngine;

public class DUEnBullet : MonoBehaviour
{
    public GameObject ddownBull;
    public float bulletSpeed = 5f;
    public Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerUnit")
        {
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = (-transform.right + transform.up/2) * bulletSpeed * enBullet.enbulletSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -4)
        {
            Destroy(gameObject);
        }

        if(transform.position.y > 2)
        {
            Instantiate(ddownBull, transform.position + new Vector3(0, -.6f, 0), transform.rotation);
            Destroy(gameObject);
        }

    }
}
