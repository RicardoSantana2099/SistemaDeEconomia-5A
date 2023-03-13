using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterShopDatabase", menuName = "Shopping/Characters shop database")]
public class CharacterShopDataBase : ScriptableObject
{
    public Character[] characters;

    public int CharactersCount
    {
        get
        {
            return characters.Length;
        }
    }
}
