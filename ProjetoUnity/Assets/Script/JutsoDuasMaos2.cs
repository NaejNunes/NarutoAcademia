using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoDuasMaos2 : GameController
{
     public bool checkD, checkW;
    // Start is called before the first frame update
    void Start()
    {
        checkD = false;
        checkW = false;

    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.D))
        {
            checkD = true;
        }
        if (Input.GetKeyUp(KeyCode.W) && checkD == true)
        {
            checkW = true;
        }

        if (checkD == true && checkW == true)
        {
            TrocaDeJutso();
        }
    }
}
