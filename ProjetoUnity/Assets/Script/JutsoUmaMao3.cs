using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoUmaMao3 : GameController
{
    public bool checkI;
    // Start is called before the first frame update
    void Start()
    {
        checkI = false;
    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.I))
        {
            checkI = true;
        }

        if (checkI == true)
        {
            TrocaDeJutso();
        }
    }
}
