using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] jutso;
    public GameObject EfeitoJutso;
    int numero; 

    public void TrocaDeJutso()
    {
            GetComponent<AudioSource>().Play();
            Instantiate(EfeitoJutso);
            ControladorDePontos.ContadorDePontos();
            InstanciarJutso();
            Destroy(gameObject);         
    }

    public void GcMenu()
    {
        GetComponent<AudioSource>().Play();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void InstanciarJutso()
    {
         
    numero = Random.Range(1, 6);

        switch (numero)
        {
           
            case 1:
            Instantiate(jutso[0]);
            break;

            case 2:
            Instantiate(jutso[1]);
            break;

            case 3:
            Instantiate(jutso[2]);
            break;

            case 4:
            Instantiate(jutso[3]);
            break;

            case 5:
            Instantiate(jutso[4]);
            break;

            case 6:
            Instantiate(jutso[5]);
            break;

        }
    }   
}
