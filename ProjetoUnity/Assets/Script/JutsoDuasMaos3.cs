using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutsoDuasMaos3 : GameController
{
    public bool checkH, checkJ;
    // Start is called before the first frame update
    void Start()
    {
        checkH= false;
        checkJ= false;

    }

    // Update is called once per frame
    void Update()
    {
        Jutso();
    }
    public void Jutso()
    {

        if (Input.GetKeyUp(KeyCode.H))
        {
            checkH = true;
        }
        if (Input.GetKeyUp(KeyCode.J) && checkH == true)
        {
            checkJ = true;
        }

        if (checkH == true && checkJ == true)
        {
            TrocaDeJutso();
        }
    }
}
