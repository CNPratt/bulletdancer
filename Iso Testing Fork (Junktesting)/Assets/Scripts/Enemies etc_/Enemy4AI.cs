using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy4AI : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip shotSFX;
    public AudioClip deathSFX;
    public GameObject myMirror;
    public bool haveMirror;
    public GameObject deathAnim;
    public LayerMask layermask;
    public CircleCollider2D enCirc;
    public bool cellLeftOpen;
    public bool cellRightOpen;
    public bool cellUpOpen;
    public bool cellDownOpen;
    public bool isLeftOccupied;
    public bool isRightOccupied;
    public bool isUpOccupied;
    public bool isDownOccupied;
    public Vector3 lastMove;
    public static float enMoveSpeed = .5f;
    public static int enHealthFactor = 0;
    private int enHealth = 3;

    IEnumerator enhitFlash()
    {
        // Debug.Log("Colorchange");
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        yield return new WaitForSeconds(.05f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        yield return new WaitForSeconds(.05f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        yield return new WaitForSeconds(.05f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == ("Weapon"))
        {
            ComboManager.killsToAdd = ComboManager.killsToAdd + 1;
            enHealth = enHealth - 1;

            if (enHealth > 0)
            {
                StartCoroutine(enhitFlash());
            }

            if (enHealth <= 0)
            {
                AudioSource.PlayClipAtPoint(deathSFX, transform.position, 1f);
                Instantiate(deathAnim, transform.position, transform.rotation);
                ScoreManager.totalScore = System.Convert.ToInt32(ScoreManager.totalScore + (20 * (1 + ComboManager.bonusFactor)));
                Destroy(gameObject);
            }

        }

            if (collision.collider.tag == ("EnemyUnit"))
            {
                //Debug.Log("Enemies grouped");
                transform.Translate(-lastMove);
            }
    }

 //   private void OnDestroy()
 //   {
        
 //       AltEnemySpawner.totalKills = (AltEnemySpawner.totalKills) + 1;
        
 //       ScoreManager.totalScore = System.Convert.ToInt32(ScoreManager.totalScore + (20 * (1 + ComboManager.bonusFactor)));
 //   }

    public Tilemap tilemap;
    public TileBase grassTile;
    public bool moveOn = true;
    public Transform firePoint;
    public GameObject enbulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        enHealth = enHealth + enHealthFactor;
        isLeftOccupied = true;
        isRightOccupied = true;
        isUpOccupied = true;
        isDownOccupied = true;

        tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();
        //        Debug.Log(GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().tilemap);

        StartCoroutine(enemyAI());
        {

        }
        IEnumerator enemyAI()
        {
            while (moveOn == true)
            {
                int roll = (int)Random.Range(1f, 5f);

                if (roll == 1 && cellLeftOpen && isLeftOccupied == false)
                {
                    transform.Translate(-.5f, -.25f, 0f);
                    lastMove = new Vector3(-.5f, -.25f, 0f);
                }
                if (roll == 2 && cellUpOpen && isUpOccupied == false)
                {
                    transform.Translate(-.5f, .25f, 0f);
                    lastMove = new Vector3(-.5f, .25f, 0f);
                }
                if (roll == 3 && cellDownOpen && isDownOccupied == false)
                {
                    transform.Translate(.5f, -.25f, 0f);
                    lastMove = new Vector3(.5f, -.25f, 0f);
                }
                if (roll == 4 && cellRightOpen && isRightOccupied == false)
                {
                    transform.Translate(.5f, .25f, 0f);
                    lastMove = new Vector3(.5f, .25f, 0f);
                }
                if(haveMirror == true)
                { }
                if (haveMirror == false)
                {
                    audioSource.PlayOneShot(shotSFX, .1f);
                    haveMirror = true;
                    myMirror = Instantiate(enbulletPrefab, firePoint.position, firePoint.rotation);
                    myMirror.GetComponent<enMirrorscript>().mirrOwner = gameObject;
                }

                yield return new WaitForSeconds(1 / enMoveSpeed);



                { }
            }
        }
    }


    void Update()
    {
        if (Weapon.plumDestro == true)
        {
            AudioSource.PlayClipAtPoint(deathSFX, transform.position, 1f);
            AltEnemySpawner.totalKills = (AltEnemySpawner.totalKills) + 1;
            ComboManager.killsToAdd = ComboManager.killsToAdd + enHealth;
            ScoreManager.totalScore = System.Convert.ToInt32(ScoreManager.totalScore + (20 * (1 + ComboManager.bonusFactor)));
            Instantiate(deathAnim, transform.position, transform.rotation);
            Destroy(gameObject);
        }


        //        Debug.DrawRay(((enCirc.transform.position + Vector3.up / 4) + new Vector3(-.5f, -.25f) / 2), new Vector2(-.5f, -.25f) * 1f, Color.green);

        //        Debug.DrawRay(((enCirc.transform.position + Vector3.up / 4) + new Vector3(.5f, -.25f) / 2), new Vector2(.5f, -.25f) * 1f, Color.green);

        //        Debug.DrawRay(((enCirc.transform.position + Vector3.up / 4) + new Vector3(-.5f, .25f) / 2), new Vector2(-.5f, .25f) * 1f, Color.green);

        //        Debug.DrawRay(((enCirc.transform.position + Vector3.up / 4) + new Vector3(.5f, .25f) / 2), new Vector2(.5f, .25f) * 1f, Color.green);

        RaycastHit2D hitLeft = Physics2D.Raycast(((enCirc.transform.position + Vector3.up / 4) + new Vector3(-.5f, -.25f) / 2), new Vector2(-.5f, -.25f), 1f, layermask);

        RaycastHit2D hitRight = Physics2D.Raycast(((enCirc.transform.position + Vector3.up / 4) + new Vector3(.5f, .25f) / 2), new Vector2(.5f, .25f), 1f, layermask);

        RaycastHit2D hitUp = Physics2D.Raycast(((enCirc.transform.position + Vector3.up / 4) + new Vector3(-.5f, .25f) / 2), new Vector2(-.5f, .25f), 1f, layermask);

        RaycastHit2D hitDown = Physics2D.Raycast(((enCirc.transform.position + Vector3.up / 4) + new Vector3(.5f, -.25f) / 2), new Vector2(.5f, -.25f), 1f, layermask);

        Vector3Int cellPosition = tilemap.WorldToCell(transform.position);

        Vector3Int nextCellLeft = cellPosition + Vector3Int.left;

        Vector3Int nextCellRight = cellPosition + Vector3Int.right;

        Vector3Int nextCellUp = cellPosition + Vector3Int.up;

        Vector3Int nextCellDown = cellPosition + Vector3Int.down;

        //  && hit(DIRECTION).collider.tag == "EnemyUnit" added to each instance to exclude LOS box collider on player

        if (hitLeft == true)
        {
            isLeftOccupied = true;
            //           Debug.Log(hitLeft.collider.tag);
            //           Debug.Log("LEFT");
        }
        if (hitRight == true)
        {
            isRightOccupied = true;
            //           Debug.Log(hitRight.collider.tag);
            //           Debug.Log("RIGHT");
        }
        if (hitUp == true)
        {
            isUpOccupied = true;
            //           Debug.Log(hitUp.collider.tag);
            //           Debug.Log("UP");
        }
        if (hitDown == true)
        {
            isDownOccupied = true;
            //           Debug.Log(hitDown.collider.tag);
            //           Debug.Log("DOWN");
        }
        if (hitDown == false)
        {
            isDownOccupied = false;
        }
        if (hitLeft == false)
        {
            isLeftOccupied = false;
        }
        if (hitRight == false)
        {
            isRightOccupied = false;
        }
        if (hitUp == false)
        {
            isUpOccupied = false;
        }
        if (hitDown == false)
        {
            isDownOccupied = false;
        }

        if (tilemap.GetTile(nextCellLeft).name == grassTile.name && isLeftOccupied == false)
        {
            cellLeftOpen = true;
        }
        else
        {
            cellLeftOpen = false;
        }
        if (tilemap.GetTile(nextCellRight).name == grassTile.name && isRightOccupied == false)
        {
            cellRightOpen = true;
        }
        else
        {
            cellRightOpen = false;
        }
        if (tilemap.GetTile(nextCellUp).name == grassTile.name && isUpOccupied == false)
        {
            cellUpOpen = true;
        }
        else
        {
            cellUpOpen = false;
        }
        if (tilemap.GetTile(nextCellDown).name == grassTile.name && isDownOccupied == false)
        {
            cellDownOpen = true;
        }
        else
        {
            cellDownOpen = false;
        }
    }
}








