using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoUmaMao2 : GameController
{
    public bool checkM;
    // Start is called before the first frame update
    void Start()
    {
        checkM = false;
    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.M))
        {
            checkM = true;
        }

        if (checkM == true)
        {
            TrocaDeJutso();
        }
    }
}
