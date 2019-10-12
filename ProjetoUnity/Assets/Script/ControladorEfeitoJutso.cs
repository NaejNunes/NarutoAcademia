using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEfeitoJutso : MonoBehaviour
{
     int contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        contador = contador - 1;
        if (contador <= 0)
        {
            Destroy(gameObject);
        }
    }
}
