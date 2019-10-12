using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoTresMaos2 : GameController
{
    public bool checkT, checkA, checkW;
    // Start is called before the first frame update
    void Start()
    {
        checkT = false;
        checkA = false;
        checkW = false;

    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.T))
        {
            checkT = true;
        }
        if (Input.GetKeyUp(KeyCode.A) && checkT == true)
        {
            checkA = true;
        }
        if (Input.GetKeyUp(KeyCode.W) && checkT == true && checkA == true)
        {
            checkW = true;
        }

        if (checkT == true && checkA == true && checkW == true)
        {
            TrocaDeJutso();
        }
    }
}
