using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tampar : MonoBehaviour
{
    bool tampado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tampado)
        {
            transform.position = new Vector3(-13, 1.05f, -3.15f);
        }
    }

    private void OnCollisionStay(Collision y)
    {
        if (tampado == false && (y.gameObject.name == "P1" && Input.GetKey(KeyCode.E)))
        {    
            transform.Rotate(-45, 0, 0);
            tampado = true;
        }
        
    }
}
