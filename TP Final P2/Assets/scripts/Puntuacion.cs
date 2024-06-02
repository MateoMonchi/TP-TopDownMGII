using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public int puntuacion;
    public TextMeshProUGUI textoPuntuacion;
    public float PuntosVictoria;
    public Image victory;
    public void Suma()
    {
        puntuacion++;
        textoPuntuacion.text = puntuacion.ToString("D3");
        if(puntuacion >= PuntosVictoria)
        {
victory.gameObject.SetActive(true);
            Time.timeScale = 0f;

        }
    }
    
    void Start()
    {
        victory.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    
    void Update()
    {
        
    }
    public void cambioDeEscena(int destino)
    {
SceneManager.LoadScene(destino);
    }
}
