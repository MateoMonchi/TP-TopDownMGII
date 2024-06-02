using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    [SerializeField] private float speed = 3f;
    
    private Rigidbody2D playerRB;

    private Vector2 moveInput;

    private Animator playerAnimator;

  
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

 
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
       if(transform.position.y < -12.4f)
        {
            transform.position = new Vector2(transform.position.x,-12.4f);
        }
        if(transform.position.y > +12.4f)
        {
            transform.position = new Vector2(transform.position.x,+12.4f);
        }
        if(transform.position.x > 21.4f)
        {
            transform.position = new Vector2(21.4f,transform.position.y);
        }
        if(transform.position.x < -21.4f)
        {
            transform.position = new Vector2(-21.4f,transform.position.y);
        }
    }
    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + moveInput * speed *Time.fixedDeltaTime);
    }




}
