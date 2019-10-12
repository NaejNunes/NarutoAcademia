using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoQuatroMaos2 : GameController
{
    public bool checkV, checkM, checkX, checkF;
    // Start is called before the first frame update
    void Start()
    {
        checkV = false;
        checkM = false;
        checkX = false;
        checkF = false;

    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.V))
        {
            checkV = true;
        }
        if (Input.GetKeyUp(KeyCode.M) && checkV == true)
        {
            checkM = true;
        }
        if (Input.GetKeyUp(KeyCode.X) && checkV == true && checkM == true)
        {
            checkX = true;
        }
        if (Input.GetKeyUp(KeyCode.F) && checkV == true && checkM == true && checkX == true)
        {
            checkF = true;
        }

        if (checkV == true && checkM == true && checkX == true && checkF == true)
        {
            TrocaDeJutso();
        }
    }
}
