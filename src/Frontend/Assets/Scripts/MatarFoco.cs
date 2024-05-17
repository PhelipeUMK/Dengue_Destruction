using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarFoco : MonoBehaviour
{
    public ParticleSystem particulasMosquitos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider z)
    {
        if ((z.gameObject.name == "P1"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (particulasMosquitos.isPlaying)
                {
                    particulasMosquitos.Stop();
                }
            }
        }
    }
}
