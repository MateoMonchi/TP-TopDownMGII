using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    float vida;
    public float vidaMax;
    public Image corazonEntero;
    public Image corazonImedio;
    public Image corazonVacio;
    public Image derrota;
    public SpriteRenderer sr;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            vida--;
            StartCoroutine(damage());

            if (vida <= vidaMax * 0.5f && vida > 0)
            {
                corazonEntero.gameObject.SetActive(false);
                corazonImedio.gameObject.SetActive(true);
            }
            if(vida <= 0)
            {
                corazonImedio.gameObject.SetActive(false);
                corazonVacio.gameObject.SetActive(true);
                Destroy(gameObject);
                derrota.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("corazon"))
        {
            vida++;
            Destroy(collision.gameObject);
        }
    }
   
    void Start()
    {
        vida = vidaMax;
        derrota.gameObject.SetActive(false);
    }

  
    void Update()
    {
        
    }
    IEnumerator damage()
    {
        sr.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sr.color = Color.white;
    }
}
