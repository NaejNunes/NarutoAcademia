using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    float milesimos, segundos, minutos;
    public Text txtTempoMinutos, txtTempoSegundos;

    // Start is called before the first frame update
    void Start()
    {
        minutos = 1;
        segundos = 0;
        milesimos = 60;
    }

    // Update is called once per frame
    void Update()
    {
        ContadorDeTempo();
    }

    //Função que controla o contador de tempo no painel do lado esquerdo no canto superior.
    public void ContadorDeTempo()
    {
        txtTempoMinutos.text = "" + minutos;
        txtTempoSegundos.text = "" + segundos;

        milesimos = milesimos - 1f;

        if (milesimos == -1f)
        {
            segundos = segundos - 1f;
            milesimos = 60f;
        }

        if (segundos == -1f)
        {
            minutos = minutos - 1f;
            segundos = 60f;
        }

        if (minutos <= 0.0f && segundos <= 0.0f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
