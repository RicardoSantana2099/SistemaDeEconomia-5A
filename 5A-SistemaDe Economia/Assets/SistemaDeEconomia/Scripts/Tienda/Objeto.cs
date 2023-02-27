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


    public void CrearObjeto(PlantillaObjeto datosObjeto)
    {
        imagenObjeto.sprite = datosObjeto.imagenObjeto;
        textoObjeto.text = datosObjeto.textoObjeto;
        precioObjeto.text = datosObjeto.precioObjeto.ToString();
    }
}
