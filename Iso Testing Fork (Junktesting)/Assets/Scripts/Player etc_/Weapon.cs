using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public static bool melonSwitch = false;

    public AudioClip pupSFX;
    public AudioSource audioSource;
    public AudioClip regshotSFX;

    public static bool plumDestro;

    public SpriteRenderer sprite;
    public GameObject thisPup;
    public GameObject gotPup;
    public GameObject mirr;
    public GameObject thisMirr;

    public BoxCollider2D diagUp;
    public BoxCollider2D diagDown;
    public BoxCollider2D regSight;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject diagupbulletPrefab;
    public GameObject diagdownbulletPrefab;
    public GameObject bigshotPrefab;
    public GameObject originalBulletPrefab;
    public GameObject bigdownPrefab;
    public GameObject bigupPrefab;
    public GameObject origdiagup;
    public GameObject origdiagdown;
    public float bulletInterval = .25f;
    public bool canShoot = true;
    public bool regWeap = true;
    public bool diagWeap = false;

    public int kiwiCounter;
    public int pearCounter;
    public static int appleCounter;
    public int orangeCounter;
    public int pappleCounter;

    IEnumerator PlumMethod()
    {
        plumDestro = true;
        yield return new WaitForSeconds(.01f);
        plumDestro = false;
    //    Destroy(GameObject.FindGameObjectWithTag("EnemyUnit"));
    }

    //public static float enBulletMoveFactor = 1;


    // Start is called before the first frame update
    void Start()
    {
        plumDestro = false;
        appleCounter = 0;
        melonSwitch = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (GrapeController.GrapeOn == true)
        {
            StartCoroutine(Grape());
        }
        if (KiwiController.KiwiOn == true)
        {
            StartCoroutine(Kiwi());
        }
        if (MelonController.MelonOn == true)
        {
            StartCoroutine(Melon());
        }
        if (OrangeController.OrangeOn == true)
        {
            StartCoroutine(Orange());
        }
        if (PlumController.PlumOn == true)
        {
            StartCoroutine(Plum());
        }

        if (PineappleController.PineappleOn == true)
        {
            StartCoroutine(Pineapple());
        }

        if (AppleController.AppleOn == true)
        {
            StartCoroutine(Apple());
        }

        if (PearController.PearOn == true)
        {
            StartCoroutine(Pear());
        }


        if (Input.GetKeyDown("space") && canShoot == true && regWeap == true && pausefunc.pauseOn == false)
        {
            StartCoroutine(ShootRegWeap());
        }

        if (Input.GetKeyDown("space") && canShoot == true && regWeap == false && diagWeap == true && pausefunc.pauseOn == false)
        {
            StartCoroutine(ShootDiagWeap());
        }


        IEnumerator ShootRegWeap()
        {
            while (Input.GetKey("space") && regWeap == true)
            {
                canShoot = false;

                audioSource.PlayOneShot(regshotSFX, .2f);

                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                yield return new WaitForSeconds(1 * bulletInterval);
                canShoot = true;

                if (diagWeap == true)
                {
                    regWeap = false;
                    StartCoroutine(ShootDiagWeap());
                }
            }
        }

        IEnumerator ShootDiagWeap()
        {
            while (Input.GetKey("space") && diagWeap == true)
            {
                canShoot = false;
                audioSource.PlayOneShot(regshotSFX, .2f);
                Instantiate(diagupbulletPrefab, firePoint.position + new Vector3(0, 0.1f, 0), firePoint.rotation);
                Instantiate(diagdownbulletPrefab, firePoint.position + new Vector3(0, -.6f, 0), firePoint.rotation);
                yield return new WaitForSeconds(1 * bulletInterval);
                canShoot = true;

                if (regWeap == true)
                {
                    diagWeap = false;
                    StartCoroutine(ShootRegWeap());
                }
            }
            
        }


        IEnumerator Kiwi()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //       Debug.Log("Kiwi");

            KiwiController.KiwiOn = false;

            if (kiwiCounter < 2)
            {
                kiwiCounter = kiwiCounter + 1;
                bulletInterval = bulletInterval / 2;
                yield return new WaitForSeconds(10);
                kiwiCounter = kiwiCounter - 1;
                bulletInterval = bulletInterval * 2;
            }
            else
            {
                ComboManager.comboCounter = ComboManager.comboCounter + 5;
            }
        }

        IEnumerator Plum()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //          Debug.Log("Plum");
            PlumController.PlumOn = false;
            if (GameObject.FindGameObjectWithTag("EnemyUnit") == true)
            {
                StartCoroutine("PlumMethod", 0);
                
            }
            yield return null;

        }

        IEnumerator Orange()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //        Debug.Log("Orange");

            regSight.enabled = false;
            diagDown.enabled = true;
            diagUp.enabled = true;

            regWeap = false;
            diagWeap = true;
            orangeCounter = orangeCounter + 1;
            OrangeController.OrangeOn = false;
            yield return new WaitForSeconds(10);
            orangeCounter = orangeCounter - 1;
            if (orangeCounter <= 0)
            {
                regSight.enabled = true;
                diagDown.enabled = false;
                diagUp.enabled = false;

                diagWeap = false;
                regWeap = true;
            }
        }

        IEnumerator Pineapple()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //        Debug.Log("Pineapple");
            bulletPrefab = bigshotPrefab;
            diagdownbulletPrefab = bigdownPrefab;
            diagupbulletPrefab = bigupPrefab;
            bulletInterval = bulletInterval * 2;
            pappleCounter = pappleCounter + 1;
            PineappleController.PineappleOn = false;
            yield return new WaitForSeconds(10);
            pappleCounter = pappleCounter - 1;
            bulletInterval = bulletInterval / 2;
            if (pappleCounter <= 0)
            {
                bulletPrefab = originalBulletPrefab;
                diagdownbulletPrefab = origdiagdown;
                diagupbulletPrefab = origdiagup;
            }
        }

        IEnumerator Melon()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;
            melonSwitch = true;

            yield return null;

            //        Debug.Log("Melon");
        //    EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed/2;
        //    enBullet.enbulletSpeed = enBullet.enbulletSpeed/(enBulletMoveFactor * 2);
        //    En2Bullet.enbulletSpeed = En2Bullet.enbulletSpeed / (enBulletMoveFactor * 2);
        //    En3Bullet.enbulletSpeed = En3Bullet.enbulletSpeed / (enBulletMoveFactor * 2);
        //    MelonController.MelonOn = false;
        //    yield return new WaitForSeconds(10);
        //    EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 2;
        //    enBullet.enbulletSpeed = enBullet.enbulletSpeed * (enBulletMoveFactor * 2);
        //    En2Bullet.enbulletSpeed = En2Bullet.enbulletSpeed * (enBulletMoveFactor * 2);
        //    En3Bullet.enbulletSpeed = En3Bullet.enbulletSpeed * (enBulletMoveFactor * 2);

        }

        IEnumerator Grape()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //        Debug.Log("Grape");
            GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth = GameObject.Find("Player(Clone)").GetComponent<HealthMech>().playerHealth + 50;
            GrapeController.GrapeOn = false;
            yield return new WaitForSeconds(10);
        }


        IEnumerator appleFlash()
        {
            while (PlayerMovement.pInvulOn == true)
            {
                sprite.color = Color.blue;
                yield return new WaitForSeconds(.05f);
                sprite.color = Color.white;
                yield return new WaitForSeconds(.05f);
            }
        }

        IEnumerator Apple()
        {
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //        Debug.Log("apple");
            
            AppleController.AppleOn = false;
            PlayerMovement.pInvulOn = true;
            appleCounter = appleCounter + 1;
            StartCoroutine(appleFlash());
            PineappleController.PineappleOn = false;
            yield return new WaitForSeconds(10);
            appleCounter = appleCounter - 1;
            if (appleCounter <= 0)
            {
                PlayerMovement.pInvulOn = false;
            }
        }

        IEnumerator Pear()
        {
            
            audioSource.PlayOneShot(pupSFX, .1f);
            thisPup = Instantiate(gotPup, transform.position - new Vector3(0, .01f, 0), transform.rotation);
            thisPup.transform.parent = gameObject.transform;

            //        Debug.Log("apple");

            PearController.PearOn = false;
            if (thisMirr == false)
            {
                thisMirr = Instantiate(mirr, transform.position + new Vector3(.15f, .3f), transform.rotation);
                thisMirr.transform.parent = gameObject.transform;
            }
            pearCounter = pearCounter + 1;
            PineappleController.PineappleOn = false;
            yield return new WaitForSeconds(10);
            pearCounter = pearCounter - 1;
            if (pearCounter <= 0)
            {
                Destroy(thisMirr);
            }
        }

    }
}