using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoDuasMaos1 : GameController
{
    public bool checkV, checkX;
    // Start is called before the first frame update
    void Start()
    {
        checkV = false;
        checkX = false;

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
        if (Input.GetKeyUp(KeyCode.X) && checkV == true)
        {
            checkX = true;
        }

        if (checkV == true && checkX == true)
        {
            TrocaDeJutso();
        }
    }
}
