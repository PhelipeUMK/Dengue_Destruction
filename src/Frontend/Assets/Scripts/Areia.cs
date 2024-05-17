using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Areia : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] areia;
    void Start()
    {
        GetComponent<Renderer>().material.color = areia[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision c)
    {
        if (c.gameObject.name == "P1")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GetComponent<Renderer>().material.color = areia[1];
            }
        }
    }
}
