using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En2Bullet : MonoBehaviour
{
    // need to make it so enemy bullets ignore player boxcollider
    public GameObject impact;
    public LayerMask layermask;
    public static float enbulletSpeed = 2.5f;
    public Rigidbody2D rb;
    public GameObject playerPrefab;
    //public GameObject curClone;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerUnit")
        {
              Instantiate(impact, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        impact.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
        //  curClone = GameObject.FindGameObjectWithTag("PlayerUnit");
        rb.velocity = -transform.right * enbulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       // float dist = Vector3.Distance(curClone.transform.position, transform.position);

        //Debug.Log(dist);
        //        Add dist to the equation below if using this
        rb.velocity = -transform.right * (enbulletSpeed * MelonManager.enBulletMoveFactor);

        if (transform.position.x < -4)
        {
            Destroy(gameObject);
        }
    }
}

