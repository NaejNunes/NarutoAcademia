using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoQuatroMaos1 : GameController
{
    public bool checkI, checkH, checkJ, checkL;
    // Start is called before the first frame update
    void Start()
    {
        checkI = false;
        checkH = false;
        checkJ = false;
        checkL = false;

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
        if (Input.GetKeyUp(KeyCode.H) && checkI == true)
        {
            checkH = true;
        }
        if (Input.GetKeyUp(KeyCode.J) && checkI == true && checkH == true)
        {
            checkJ = true;
        }
        if (Input.GetKeyUp(KeyCode.L) && checkI == true && checkJ == true && checkJ == true)
        {
            checkL = true;
        }

        if (checkI == true && checkJ == true && checkJ == true && checkL == true)
        {
            TrocaDeJutso();
        }
    }
}
