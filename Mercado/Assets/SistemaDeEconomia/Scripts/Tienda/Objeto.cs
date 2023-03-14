using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Objeto : MonoBehaviour
{
    [SerializeField] Image imagenObjeto;
    [SerializeField] TextMeshProUGUI textoObjeto;
    [SerializeField] TextMeshProUGUI precioObjeto;

    private int precio;
    private Equipo equipo;

    private void Awake()
    {
        equipo = FindObjectOfType<Equipo>();
    }

    public void CrearObjeto(PlantillaObjeto datosObjeto)
    {
        precio = datosObjeto.precioObjeto;
        imagenObjeto.sprite = datosObjeto.imagenObjeto;
        textoObjeto.text = datosObjeto.textoObjeto;
        precioObjeto.text = datosObjeto.precioObjeto.ToString();
    }

    public void ComprarObjeto()
    {
        equipo.IncluirEquipo(precio, imagenObjeto);
    }
}
