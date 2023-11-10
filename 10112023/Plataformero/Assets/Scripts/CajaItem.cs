using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaItem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//Este metodo se ejecuta cuando el objeto dectecta una colision 

        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print(name + "detecte colision con" + collision.gameObject);
            //con estas insrtucciones obtengo el componente personaje del player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esto le mando el daño al personaje por 20 puntos y le dgo qye gye este objeto el que lo daño 

        }

    }