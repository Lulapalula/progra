using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public int danio;
    public float duracion;
    private bool potiUsada;

    private Personaje elPerso;
    private Animator miAnimador;


    // Start is called before the first frame update
    void Start()
    {
        potiUsada = false;
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.tag == "Player")
        {
            potiUsada = true;

            print(name + "detecte colision con" + collision.gameObject);
            //con estas insrtucciones obtengo el componente personaje del player

            elPerso = otroObjeto.GetComponent<Personaje>();

            if (potiUsada == true)
            {
                //con esto le mando el daño al personaje por 20 puntos y le dgo qye gye este objeto el que lo daño 
                InvokeRepeating("danioVeneno", 0, 1);
                miAnimador.SetTrigger("Desaparece");
                Invoke("destruirObjeto", duracion);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        potiUsada = false;
    }
    public void danioVeneno()
    {
        elPerso.hacerDanio(danio, this.gameObject);
    }
    public void destruirObjeto()
    {
        Destroy(gameObject);
        Debug.Log("objeto destruido");
    }
}
