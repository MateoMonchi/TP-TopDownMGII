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
    }
    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + moveInput * speed *Time.fixedDeltaTime);
    }
}
