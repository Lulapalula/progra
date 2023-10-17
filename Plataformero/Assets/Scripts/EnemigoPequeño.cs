using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequeño : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private bool cerca = false;
    public float velocidadCaminar = 2;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>(); // Invocación del componente
        miAnimador = GetComponent<Animator>();
    }


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.CompareTag("Player"))
        {
            if (otroObjeto.tag == "Player")
            {
                Personaje elPerso = otroObjeto.GetComponent<Personaje>();
                print("El jugador está cerca del enemigo");
            }

            // Obtener la posición del jugador y del enemigo
            Vector3 posicionHeroe = otroObjeto.transform.position;
            Vector3 posicionEnemigo = transform.position;

            // Comprobar si el jugador está a la izquierda del enemigo
            if (posicionHeroe.x < posicionEnemigo.x)
            {
                // Girar al enemigo a 0 grados (mirando hacia la izquierda)
                transform.rotation = Quaternion.Euler(0, 180, 0);

                // Activar el atributo BOOL "cerca"
                cerca = true;
            }

            if (posicionHeroe.x > posicionEnemigo.x)
            {
                // Girar al enemigo a 180 grados (mirando hacia la derecha)
                transform.rotation = Quaternion.Euler(0, 0, 0);

               
                cerca = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.CompareTag("Player"))
        {
            print("Está lejos aaaaa");
            cerca = false; // Cuando el jugador se aleja, desactiva el atributo "cerca"
        }
    }

    void Update()
    {
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        if (cerca)
        {//se mueve a la dere
            miCuerpo.velocity = transform.right * velocidadCaminar;
            miAnimador.SetBool("CAMINANDO", true);

        }

        else
        {
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("CAMINANDO", false);
        }

    }
}
