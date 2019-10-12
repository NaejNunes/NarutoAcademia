using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoTresMaos3 : GameController
{
    public bool checkX, checkV, checkD;
    // Start is called before the first frame update
    void Start()
    {
        checkX = false;
        checkV = false;
        checkD = false;

    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.X))
        {
            checkX = true;
        }
        if (Input.GetKeyUp(KeyCode.V) && checkX == true)
        {
            checkV = true;
        }
        if (Input.GetKeyUp(KeyCode.D) && checkX == true && checkV == true)
        {
            checkD = true;
        }

        if (checkX == true && checkV == true && checkD == true)
        {
            TrocaDeJutso();
        }
    }
}
