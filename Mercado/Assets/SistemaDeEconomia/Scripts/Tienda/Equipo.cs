using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Equipo : MonoBehaviour
{
    [SerializeField] private int dineroTotal = 50;//Una cantidad predefinida de dinero que va a tener el jugador.   
    [SerializeField] TextMeshProUGUI textoDinero;// Va a mostrar el dinero en pantalla.
    [SerializeField] GameObject objetoDeEquipo; // Va ser una referencia a unuestros objetos de equipo.

    private int numeroMaximoObjetos = 0;//Es la referencia de la cantidad de objetos maximos que podemos tener en nuestro equipo.

    private void Start()
    {
        textoDinero.text = dineroTotal.ToString();// Vamos a mostrar el dinero que tenemos en cada momento.
    }

    public void IncluirEquipo(int dinero, Image imagenEquipo) //Este va a crear los elementos del equipo.
    {
        if(dinero <= dineroTotal && numeroMaximoObjetos <= 11) //Si tenemos el suficiente dinero y el numero de objetos no supera el maximo de objetos total.
        {
            dineroTotal -= dinero; //se va a restar la cantidad de dinero total.
            numeroMaximoObjetos++; // se va a sumar el numero maximo de objetos, para no exceder el numero maximo de objetos.
            GameObject equipo = GameObject.Instantiate(objetoDeEquipo, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Equipo").transform);
            Image imagen = equipo.GetComponent<Image>();// Va a tomar como referencia nuestra imagen de objeto de nuestro equipo.
            imagen.sprite = imagenEquipo.sprite; // A essta imagen se le va a cambiar el sprite por la variable en el metodo start (textoDinero.text = dineroTotal.ToString();).
            textoDinero.text = dineroTotal.ToString();// Se va a actualzar el texto de dinero para dar la nueva cantidad.
        }
    }

}
