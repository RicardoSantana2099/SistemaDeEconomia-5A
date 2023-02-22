using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Diamantes : BloqueBase
{
    // Start is called before the first frame update
    void Start()
    {
        nombre = "Diamante";
        gravedad = false;
        GetComponent<SpriteRenderer>().sprite = textura;
    }
     public override void destruir()
    {
        soltarItem();
        soltarXP();
        sonidoRoptura();
    }
   
    public void soltarItem()
    {

    }

    public void soltarXP()
    {

    }

    public void sonidoRoptura()
    {

    }
    void Update()
    {
        
    }
}
