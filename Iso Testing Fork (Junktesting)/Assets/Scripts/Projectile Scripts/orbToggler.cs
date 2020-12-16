using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbToggler : MonoBehaviour
{
    public GameObject orb;

    private void OnDestroy()
    {
        orb.GetComponent<orbanimScript>().orbToggle = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
