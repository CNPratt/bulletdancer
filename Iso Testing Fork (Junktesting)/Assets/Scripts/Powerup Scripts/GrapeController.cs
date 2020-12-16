using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GrapeController : MonoBehaviour
{
    public bool pupExp;
    public SpriteRenderer sprite;
    public static bool GrapeOn;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "PlayerUnit")
        {
            GrapeOn = true;
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Powerups" && collision.collider.name != "PuppointBlocker")
        {
            AltPUPSpawner.FindObjectOfType<AltPUPSpawner>().treasureLoader = AltPUPSpawner.FindObjectOfType<AltPUPSpawner>().treasureLoader + 1;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(pupCycle());

        IEnumerator pupCycle()
        {
            yield return new WaitForSeconds(7);
            pupExp = true;
            StartCoroutine(Expiring());
            //anim switch
            yield return new WaitForSeconds(3);
            pupExp = false;
            Destroy(gameObject);
            yield return true;
        }

        IEnumerator Expiring()
        {
            while (pupExp == true)
            {
                sprite.color = Color.black;
                yield return new WaitForSeconds(.05f);
                sprite.color = Color.white;
                yield return new WaitForSeconds(.05f);
            }
        }
    }
}
