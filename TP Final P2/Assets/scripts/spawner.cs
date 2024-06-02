using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] enemigos;
    public Transform[] spawnPoint;
    public float spawnTime;

    void Start()
    {
        InvokeRepeating("spawnear",0,spawnTime); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnear()
    {
        int randomEnemy = Random.Range(0, enemigos.Length);
        int randomPoint = Random.Range(0, spawnPoint.Length);

        Instantiate(enemigos[randomEnemy], spawnPoint[randomPoint].position, enemigos[randomEnemy].transform.rotation);
    }
}
