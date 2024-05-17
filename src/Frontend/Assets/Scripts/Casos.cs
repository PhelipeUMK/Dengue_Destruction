using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Casos : MonoBehaviour
{
    int casos = 0;
    public TMP_Text casosTotal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        casos++;
        casosTotal.SetText($"Casos: {casos}");
    }
}
