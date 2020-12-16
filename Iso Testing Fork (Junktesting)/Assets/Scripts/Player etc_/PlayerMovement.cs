using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer sprite;

    public static bool pInvulOn;
    public float pMoveTime;
    public bool canMove;

    public bool cellLeftOpen;
    public bool cellRightOpen;
    public bool cellUpOpen;
    public bool cellDownOpen;

    public Tilemap tilemap;
    public TileBase grassTile;


    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        pMoveTime = .1f;
        tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();

        IEnumerator invulFlash()
        {
            while (pInvulOn == true)
            {
                sprite.color = Color.blue;
                yield return new WaitForSeconds(.05f);
                sprite.color = Color.white;
                yield return new WaitForSeconds(.05f);
            }
        }


        StartCoroutine(pInvul());

        IEnumerator pInvul()
        {
            pInvulOn = true;
            sprite.color = Color.clear;
            StartCoroutine(invulFlash());
            yield return new WaitForSeconds(3f);

            if (Weapon.appleCounter < 1)
            {
                pInvulOn = false;
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3Int cellPosition = tilemap.WorldToCell(transform.position);

        Vector3Int nextCellLeft = cellPosition + Vector3Int.left;

        Vector3Int nextCellRight = cellPosition + Vector3Int.right;

        Vector3Int nextCellUp = cellPosition + Vector3Int.up;

        Vector3Int nextCellDown = cellPosition + Vector3Int.down;

  //      Debug.Log(tilemap.GetTile(cellPosition).name);

//        Debug.Log(tilemap.GetCellCenterWorld(cellPosition));

        if (tilemap.GetTile(nextCellLeft).name == grassTile.name)
        {
            cellLeftOpen = true;
        }
        else
        {
            cellLeftOpen = false;
        }
        if (tilemap.GetTile(nextCellRight).name == grassTile.name)
        {
            cellRightOpen = true;
        }
        else
        {
            cellRightOpen = false;
        }
        if (tilemap.GetTile(nextCellUp).name == grassTile.name)
        {
            cellUpOpen = true;
        }
        else
        {
            cellUpOpen = false;
        }
        if (tilemap.GetTile(nextCellDown).name == grassTile.name)
        {
            cellDownOpen = true;
        }
        else
        {
            cellDownOpen = false;
        }
            StartCoroutine(pMoveInterval());
            {

            }
        IEnumerator pMoveInterval()
        {
//changed from while to if:
            if (canMove == true)
            {

                if (Input.GetKey("a") && cellLeftOpen == true)
                {
                        canMove = false;
                        transform.Translate(-.5f, -.25f, 0f);
                        yield return new WaitForSeconds(pMoveTime);
                        canMove = true;
                    
                }


                if (Input.GetKey("w") && cellUpOpen == true)
                {
                        canMove = false;
                        transform.Translate(-.5f, .25f, 0f);
                        yield return new WaitForSeconds(pMoveTime);
                        canMove = true;

                }
                if (Input.GetKey("s")&& cellDownOpen == true)
                {
                        canMove = false;
                        transform.Translate(.5f, -.25f, 0f);
                        yield return new WaitForSeconds(pMoveTime);
                        canMove = true;

                }
                if (Input.GetKey("d") && cellRightOpen == true)
                {
                        canMove = false;
                        transform.Translate(.5f, .25f, 0f);
                        yield return new WaitForSeconds(pMoveTime);
                        canMove = true;
                }


                yield return null;

            }
        }
    }
}

        