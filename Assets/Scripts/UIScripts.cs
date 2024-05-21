using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScripts : MonoBehaviour
{
    public void Cargar(string escena)
    {
        SceneManager.LoadScene(escena);
    }


    public void Salir()
    {
        Application.Quit();
    }
}
