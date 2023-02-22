using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueBase : MonoBehaviour
{
    public string nombre;
    public bool gravedad;
    public bool puedeRomperse;
    public Sprite textura;

    public virtual void destruir()
    {

    }
}
