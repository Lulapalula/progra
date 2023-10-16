using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{

    public GameObject splashAguaPrefab;
    private EfectosSonoros misSonidos;

    void Start()
    {
        misSonidos = GetComponent<EfectosSonoros>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {//Este metodo se ejecuta cuando el objeto dectecta una colision 

        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            elPerso.instaKill(this.gameObject);

            misSonidos.reproducir("splash");

            GameObject efectoSplash = Instantiate(splashAguaPrefab);
            efectoSplash.transform.position = elPerso.transform.position;

          
        }


    }
}
