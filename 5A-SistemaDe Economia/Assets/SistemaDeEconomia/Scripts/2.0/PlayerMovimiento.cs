using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovimiento : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator animator;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        string tag = other.collider.tag;

        if(tag.Equals("Moneda"))
        {
            Debug.Log("Toma la moneda");

            Destroy(other.gameObject);
        }
    }
}
