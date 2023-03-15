using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Objeto : MonoBehaviour
{
    [SerializeField] Image imagenObjeto; //La imagen del objeto.
    [SerializeField] TextMeshProUGUI textoObjeto; //Nombre del objeto.
    [SerializeField] TextMeshProUGUI precioObjeto;//Precio del objeto.

    private int precio;
    private Equipo equipo;

    private void Awake()
    {
        equipo = FindObjectOfType<Equipo>();
    }

    public void CrearObjeto(PlantillaObjeto datosObjeto)//Metodo que va a pasar la información del objeto a las variables del prefab.
    {
        precio = datosObjeto.precioObjeto; //Se va a actualizar el dinero con el del scriptable.
        imagenObjeto.sprite = datosObjeto.imagenObjeto;//Aqui se define la imagen del objeto.
        textoObjeto.text = datosObjeto.textoObjeto;//Aqui se define el nombre del objeto.
        precioObjeto.text = datosObjeto.precioObjeto.ToString();//Aqui se va a definir el precio del objeto.
    }

    public void ComprarObjeto()
    {
        equipo.IncluirEquipo(precio, imagenObjeto); //Este se va a ejecutar cuando se presione el boton.
    }
}
