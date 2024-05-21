using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public TextMeshProUGUI timer;
    private float tiempo;
    public static bool Vivo = true;

    private void Start()
    {
        Vivo = true;
    }
    void Update()
    {
        if (Vivo)
        {
            tiempo += Time.deltaTime;
            timer.text = tiempo.ToString("F2");    
        }
    }

    public void GameOver()
    {
        Vivo = false;
        GameOverUI.SetActive(true);
    }
}
