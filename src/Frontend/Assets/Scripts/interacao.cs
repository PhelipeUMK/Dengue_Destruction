using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class interacao : MonoBehaviour
{
    bool teste = false;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(teste){
            for (int i = 0; i < 30; i++)
            {
                transform.Translate(0, 0.15f * Time.deltaTime, 0);
            }

            Debug.Log("Aqui1");   
            if(i < 370)
            {
                transform.Rotate(0, 0, i * Time.deltaTime * 2);
                i++;
                Debug.Log("Aqui2");
            }
           
            else
            {
                teste = false;
                Debug.Log("Aqui3");              
            }
           
        }

    }

     void OnTriggerStay(Collider x)
     {
         if ((x.gameObject.name == "P1" && Input.GetKey(KeyCode.E)))
         {
            teste = true;
            Debug.Log("Aqui4");
         }
     }
}
