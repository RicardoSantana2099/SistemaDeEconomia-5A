using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 2.0f;
    public float tiempoEnMoverse = 2.0f;
    public Animator animator;

    private Rigidbody2D npcRB;
    private Vector2 direccionDeMovimiento;
    private float tiempoDesdeElUltimoMovimiento = 0f;

    private void Start()
    {
        npcRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        tiempoDesdeElUltimoMovimiento += Time.deltaTime;
        
        if(tiempoDesdeElUltimoMovimiento >= tiempoEnMoverse)
        {
            direccionDeMovimiento = Random.insideUnitCircle.normalized * speed;
            tiempoDesdeElUltimoMovimiento = 0.0f;
           
        }

        npcRB.MovePosition(npcRB.position + direccionDeMovimiento * Time.deltaTime);

        animator.SetFloat("Horizontal", direccionDeMovimiento.x);
        animator.SetFloat("Vertical", direccionDeMovimiento.y);
        animator.SetFloat("Speed", direccionDeMovimiento.sqrMagnitude);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direccionDeMovimiento = -direccionDeMovimiento; //Cuando impacte con cualquier objeto cambia de dirección.
    }

}
