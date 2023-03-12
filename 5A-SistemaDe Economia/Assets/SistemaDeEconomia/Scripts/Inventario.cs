using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public GameObject inventario;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E ))
        {
            inventario.SetActive(!inventario.activeSelf);
        }
    }
}
