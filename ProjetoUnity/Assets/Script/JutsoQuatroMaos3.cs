using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoQuatroMaos3 : GameController
{
    bool checkW, checkA, checkT, checkD;
    // Start is called before the first frame update
    void Start()
    {
        checkW = false;
        checkA = false;
        checkT = false;
        checkD = false;

    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.W))
        {
            checkW = true;
        }
        if (Input.GetKeyUp(KeyCode.A) && checkW == true)
        {
            checkA = true;
        }
        if (Input.GetKeyUp(KeyCode.T) && checkW == true && checkA == true)
        {
            checkT = true;
        }
        if (Input.GetKeyUp(KeyCode.D) && checkW == true && checkA == true && checkT == true)
        {
            checkD = true;
        }

        if (checkW == true && checkA == true && checkT == true && checkD == true)
        {
            TrocaDeJutso();
        }
    }
}
