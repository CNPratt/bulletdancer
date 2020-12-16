using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shockgroupdestro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator sgDestro()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        }
        StartCoroutine(sgDestro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
