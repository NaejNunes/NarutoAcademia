using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBolaDeFogo : GameController
{
    public bool checkT, checkV, checkX, checkF, checkH;

    // Start is called before the first frame update
    void Start()
    {
        checkT = false;
        checkV = false;
        checkX = false;
        checkF = false;
        checkH = false;
    }

    // Update is called once per frame
    void Update()
    {
        JutsoBoladeFogo();
    }

    public void JutsoBoladeFogo()
    {
        // T V X F H

        if (Input.GetKeyUp(KeyCode.T))
        {
            checkT = true;
        }

        if (Input.GetKeyUp(KeyCode.V) && checkT == true)
        {
            checkV = true;
        }

        if (Input.GetKeyUp(KeyCode.X) && checkT == true && checkT == true)
        {
            checkX = true;
        }

        if (Input.GetKeyUp(KeyCode.F) && checkT == true && checkV == true && checkX == true)
        {
            checkF = true;
        }

        if (Input.GetKeyUp(KeyCode.H) && checkT == true && checkV == true && checkX == true && checkF == true)
        {
            checkH = true;
        }

        if (checkT == true && checkV == true && checkX == true && checkF == true && checkH == true)
        {
            TrocaDeJutso();
        }
    }
}
