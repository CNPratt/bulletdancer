using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class iconScript : MonoBehaviour
{
    public int iconState;
    public SpriteRenderer rend;
    public Sprite restState;
    public Sprite hurtState;
    public Sprite deadState;
    public Sprite pupState;

    public GameObject pupicon;
    public GameObject rezicon;

    // Start is called before the first frame update
    void Start()
    {
        iconState = 0;
        rend = gameObject.GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        IEnumerator iconHitFlash()
        {
            rend.color = Color.black;
            yield return new WaitForSeconds(.05f);
            rend.color = Color.white;
            yield return new WaitForSeconds(.05f);
            rend.color = Color.black;
            yield return new WaitForSeconds(.05f);
            rend.color = Color.white;

            if(iconState == 1)
            {
                iconState = 0;
            }
        }
        IEnumerator invulFlash()
        {
            while (PlayerMovement.pInvulOn == true)
            {
                rend.color = Color.blue;
                yield return new WaitForSeconds(.1f);
                rend.color = Color.white;
                yield return new WaitForSeconds(.1f);

            }
            if(PlayerMovement.pInvulOn == false)
            {
                yield break;
            }
        }

        if(GameObject.Find("gotPupobj(Clone)") == true)
        {
            pupicon.SetActive(true);
        }
        else
        {
            pupicon.SetActive(false);
        }

        if (GameObject.Find("rezzringobj(Clone)") == true)
        {
            rezicon.SetActive(true);
        }
        else
        {
            rezicon.SetActive(false);
        }

        if (PlayerMovement.pInvulOn == true)
        {
            StartCoroutine(invulFlash());
        }





        if (iconState == 0)
        {
            rend.sprite = restState;
        }

        if (iconState == 1)
        {
            rend.sprite = hurtState;
            StartCoroutine(iconHitFlash());
        }
        if (iconState == 2)
        {
            rend.sprite = deadState;
        }
    }
}
