using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoTresMaos1 : GameController
{
    public bool checkM, checkF, checkL;
    // Start is called before the first frame update
    void Start()
    {
        checkM = false;
        checkF = false;
        checkL = false;

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
        if (Input.GetKeyUp(KeyCode.F) && checkM == true)
        {
            checkF = true;
        }
        if (Input.GetKeyUp(KeyCode.L) && checkM == true && checkF == true)
        {
            checkL = true;
        }

        if (checkM == true && checkF == true && checkL == true)
        {
            TrocaDeJutso();
        }
    }
}
