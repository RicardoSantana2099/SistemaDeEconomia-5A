using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Venta : MonoBehaviour
{

    public GameObject Admiracion; //El signo de admiración para hacer la alerta.
    public GameObject Mouse; //El mouse que explica como activar;
    
    private bool isPlayerInRange;//Esta me va a indicar si el jugador esta cerca del rango.
    private bool didTradingStart;//Para saber si el tradeo ya emepzo.

    public GameObject panelDeEquipo;//Para tener referencia al panel de dialogo. 
    public GameObject panelDeTienda;//Para tener referencia a la tienda.
 
    void Update()
    {
        if(isPlayerInRange && Input.GetButtonDown("Fire1"))//El inventario del vendedor se va a abrir cuando el player este en el area y presiona click.
        {
            StartTrading();
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            FinalTrading();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)//Cuando pasen por el trigger este se va a activar.
    {
        if(collision.gameObject.CompareTag("Player"))//Solo el que tenga el tag player lo puede activar.
        {
            isPlayerInRange = true;
            Admiracion.SetActive(true);//Se activa el simbolo de admiración al momento de estar cerca del vendedor.
            Mouse.SetActive(true);//Se activa el mouse al momento de estar cerca del vendedor.
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))//Solo el player puede desactivar.
        {
            isPlayerInRange = false;
            Admiracion.SetActive(false);//Se desactiva el simbolo de admiración al momento de alejarse del vendedor.
            Mouse.SetActive(false);//Se desactiva el mouse.
        }
    }

    void StartTrading()
    {
        didTradingStart = true;
        panelDeEquipo.SetActive(true);
        panelDeTienda.SetActive(true);
        Admiracion.SetActive(false);
        Mouse.SetActive(false);
    }

    void FinalTrading()
    {
        panelDeEquipo.SetActive(false);
        panelDeTienda.SetActive(false);
    }
}
