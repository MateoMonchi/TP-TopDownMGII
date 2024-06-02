using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPoint;
    public float bulletSpeed;

   
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var a = Instantiate(bullet, shootPoint.position, shootPoint.rotation);

            a.GetComponent<Rigidbody2D>().velocity = shootPoint.up * bulletSpeed * 4 * Time.deltaTime;
        }
    }
}
