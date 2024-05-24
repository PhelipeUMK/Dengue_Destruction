using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tampar2 : MonoBehaviour
{
    bool tampado = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay(Collision y)
    {
        if ((y.gameObject.name == "P1" && Input.GetKey(KeyCode.E)))
        {
            if (tampado == false)
            {
                transform.Rotate(-45, 0, 0);
                transform.position = new Vector3(22, 1.05f, -6);
                tampado = true;
            }
        }
    }
}
