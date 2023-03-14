using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Equipo : MonoBehaviour
{
    [SerializeField] private int dineroTotal = 50;
    [SerializeField] TextMeshProUGUI textoDinero;
    [SerializeField] GameObject objetoDeEquipo;

    private int numeroMaximoObjetos = 0;

    private void Start()
    {
        textoDinero.text = dineroTotal.ToString();
    }

    public void IncluirEquipo(int dinero, Image imagenEquipo)
    {
        if(dinero <= dineroTotal && numeroMaximoObjetos <= 4)
        {
            dineroTotal -= dinero;
            numeroMaximoObjetos++;
            GameObject equipo = GameObject.Instantiate(objetoDeEquipo, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Equipo").transform);
            Image imagen = equipo.GetComponent<Image>();
            imagen.sprite = imagenEquipo.sprite;
        }
    }
}
