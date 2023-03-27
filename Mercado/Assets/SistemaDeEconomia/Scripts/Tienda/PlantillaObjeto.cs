using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Objeto", menuName = "Objeto Tienda")] //Aqui es donde se va a crear el scriptable
public class PlantillaObjeto : ScriptableObject
{
    public Sprite imagenObjeto;//Esta va a ser la imagen del objeto. 
    public string textoObjeto;//Esta va a ser el nombre del objeto.
    public int precioObjeto; // Este va a ser el precio del objeto.
}
