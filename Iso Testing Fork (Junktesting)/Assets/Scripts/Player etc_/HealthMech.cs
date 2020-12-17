using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMech : MonoBehaviour
{
    public AudioClip gothitSFX;
    public AudioSource audioSource;
    public GameObject thisrezz;
    public GameObject rezzAnim;
    public bool shockOn;
    public int enDamageFactor = 1;
    public int playerHealth;
    public int maxHealth;
    public SpriteRenderer sprite;

    IEnumerator shockDMG()
    {
        shockOn = true;
        AudioSource.PlayClipAtPoint(gothitSFX, transform.position, 1f);
        playerHealth = playerHealth - 3;
        yield return new WaitForSeconds(.5f);
        shockOn = false;
    }

    IEnumerator hitFlash()
    {
        AudioSource.PlayClipAtPoint(gothitSFX, transform.position, 1f);
        // Debug.Log("Colorchange");
        sprite.color = Color.black;
        yield return new WaitForSeconds(.05f);
        sprite.color = Color.white;
        yield return new WaitForSeconds(.05f);
        sprite.color = Color.black;
        yield return new WaitForSeconds(.05f);
        sprite.color = Color.white;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "enbulletPrefab(Clone)" && PlayerMovement.pInvulOn == false)
        {
            StartCoroutine(hitFlash());
            GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 1;
            //Debug.Log("take dmg");
            playerHealth = playerHealth - 1;
        }
        if (collision.collider.name == "en2bulletPrefab(Clone)" && PlayerMovement.pInvulOn == false)
        {
            StartCoroutine(hitFlash());
            //Debug.Log("take dmg");
            playerHealth = playerHealth - 3;
        }
        if (collision.collider.name == "en3bulletPrefab(Clone)" && PlayerMovement.pInvulOn == false)
        {
            GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 1;
            StartCoroutine(hitFlash());
            //Debug.Log("take dmg");
            playerHealth = playerHealth - 5;
        }
        if (collision.collider.name == "dgdEnbulletPrefab(Clone)" && PlayerMovement.pInvulOn == false)
        {
            GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 1;
            StartCoroutine(hitFlash());
            //Debug.Log("take dmg");
            playerHealth = playerHealth - 3;
        }

        if (collision.collider.name == "dguEnbulletPrefab(Clone)" && PlayerMovement.pInvulOn == false)
        {
            GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 1;
            StartCoroutine(hitFlash());
            //Debug.Log("take dmg");
            playerHealth = playerHealth - 3;
        }
        if (collision.collider.name == "Shockorb" && PlayerMovement.pInvulOn == false)
        {
            GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 1;
            StartCoroutine(hitFlash());
            //Debug.Log("take dmg");
            playerHealth = playerHealth - 3;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.name == "Shockorb" && PlayerMovement.pInvulOn == false)
        {
            if (shockOn == false)
            {
                GameObject.Find("pIcon").GetComponent<iconScript>().iconState = 1;
                StartCoroutine(hitFlash());
                StartCoroutine(shockDMG());
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        playerHealth = 100;

        thisrezz = Instantiate(rezzAnim, transform.position - new Vector3(0, .01f, 0), transform.rotation);
        thisrezz.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
       if (playerHealth > maxHealth)
       {
           playerHealth = maxHealth;
        }
    }
}
