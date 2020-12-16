using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboDisplay : MonoBehaviour
{
    public Text Combo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Combo.text = ComboManager.comboCounter.ToString();
    }
}
