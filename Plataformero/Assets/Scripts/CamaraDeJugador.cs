using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraDeJugador : MonoBehaviour
{
    public Personaje suPersonaje;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (suPersonaje.estaVivo())
       {
           transform.position = new Vector3(
           suPersonaje.transform.position.x, //pos x
           suPersonaje.transform.position.y, //pos y
           -1); //pos z
       }


    }
}
