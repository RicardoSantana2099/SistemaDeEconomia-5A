using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseDeDatosPersonajesTienda", menuName = "Shooping/Characters shop database")]
public class BaseDeDatosPersonajesTienda : ScriptableObject
{
    public Personajes[] characters;

    public int CharactersCount
    {
        get
        {
            return characters.Length;
        }
    }

    public Personajes GetCharacter(int index)
    {
        return characters[index];
    }
    public void PurchaseCharacter(int index)
    {
        characters[index].isPurchased = true;
    }
}
