using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoUmaMao1 : GameController
{
    public bool checkL;
    // Start is called before the first frame update
    void Start()
    {
        checkL = false;
    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.L))
        {
            checkL = true;
        } 

        if (checkL == true)
        {
            TrocaDeJutso();
        }
    }
}
