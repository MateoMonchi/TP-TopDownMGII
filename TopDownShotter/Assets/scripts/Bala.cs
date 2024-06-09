using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float life;

    void Start()
    {
        Invoke("Kill", life);

    }

    
    public void Kill()
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            Kill();
        }
    }
}
