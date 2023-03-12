using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public GameObject inventario;
    private bool inventarioAbierto = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventarioAbierto = !inventarioAbierto;
            inventario.SetActive(inventarioAbierto);
        }
    }
}
