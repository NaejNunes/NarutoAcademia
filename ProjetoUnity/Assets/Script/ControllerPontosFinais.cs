using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerPontosFinais : MonoBehaviour
{
    public Text txtPontos;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 

        PontosFinais();

        GcGameOver();
    }
    public void PontosFinais()
    {
        txtPontos.text = " " + ControladorDePontos.pontos;      
    }

    public void GcGameOver()
    {   
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ControladorDePontos.pontos = 0;

            SceneManager.LoadScene("GamePlay");
        }
    }
}
