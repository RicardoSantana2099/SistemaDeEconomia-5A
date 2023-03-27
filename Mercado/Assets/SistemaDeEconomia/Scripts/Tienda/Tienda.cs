using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    [SerializeField] GameObject prefabObjetoTienda; //Este va a usar el prefab de la tienda.
    [SerializeField] int numeroMaximoObjetosTienda;//El numero maximo de objetos que va a tener la tienda.
    [SerializeField] PlantillaObjeto[] listaTienda;//Va a contener todos los objetos scriptables.
    [SerializeField] List<PlantillaObjeto> listaProvisionalTienda;//Se va a crear una lista de objetos que no esten dentro de la tienda de manera visual (estos pueden aparecer, todo es aleatorio).

    private Objeto objeto; //Una referencia al script de objeto.

    private void Start()
    {
        listaProvisionalTienda.AddRange(listaTienda);//Este va a incluir a todos lo elementos en la lista.

        for(int i = 0; i <= numeroMaximoObjetosTienda - 1; i++)//Se va a encargar de colocar cada uno de los objetos en la tienda.
        {
            GameObject tienda = GameObject.Instantiate(prefabObjetoTienda, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Tienda").transform);//Este va a buscar el objeto que tenga el tag tienda y ahi ponga los objetos.
                int indice = Random.Range(0, listaProvisionalTienda.Count);//Los va a colocar de manera aleatoria y que sea el numero de objetos que tenga.
            objeto = tienda.GetComponent<Objeto>();//Aqui se va a buscar el metodo que se creo en el script objeto.
            objeto.CrearObjeto(listaProvisionalTienda[indice]);//Se va a llamar al metodo.
            listaProvisionalTienda.Remove(listaProvisionalTienda[indice]);//Le vamos a decir que elimine el elemento de la lista para que no se vuelva a repetir.
        }
    }
}
