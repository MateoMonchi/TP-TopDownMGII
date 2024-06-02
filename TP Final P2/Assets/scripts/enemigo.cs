using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
    public NavMeshAgent agent;
    GameObject player;
    public Animator animator;
    public float live;
    public GameObject corazon;
    Puntuacion puntuacion;
    public Color basico;
    public SpriteRenderer sr;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            live--;
            StartCoroutine(damage());
            if (live <= 0)
            {
                animator.SetBool("alive", false);
                agent.speed = 0;
                Invoke("death", 0.5f);
               
            }
        }
    }

    void Start()
    {
        animator.SetBool("alive", true);
        player = GameObject.FindWithTag("Player");
        puntuacion = FindObjectOfType<Puntuacion>();
        sr.color = basico;
    }

    
    void Update()
    {
        agent.SetDestination(player.transform.position);
        animator.SetFloat("speed",agent.velocity.magnitude);
        
    }
    public void death()
    {
        Destroy(gameObject);
        Instantiate(corazon, transform.position, corazon.transform.rotation);
        puntuacion.Suma();
    }
    IEnumerator damage()
    {
        sr.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sr.color = basico;
    }
}
