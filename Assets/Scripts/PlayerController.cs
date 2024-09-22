using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    [SerializeField] private float moveSpeed;
    private bool canMove;

    private Rigidbody2D rb;

    void Awake() {
        canMove = true;
    }

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        HandleMovement();
    }

    private void HandleMovement(){
        if(!canMove)
            return;

        Vector2 moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rb.velocity = moveDirection * moveSpeed;
    }
}
