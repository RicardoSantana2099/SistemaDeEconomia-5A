using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{
 public float velocidad = 5f; //Velocidad con la que se mueve el jugador.
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");//Dirección en el eje X.
        float moveY = Input.GetAxisRaw("Vertical");//Dirección en el eje Y.
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);
    }
}
