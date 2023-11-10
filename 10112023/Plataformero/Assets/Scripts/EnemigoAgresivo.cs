using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAgresivo : MonoBehaviour
{
    public float velocidadCaminar = 3;
    private bool heroeCerca = false;
    public float rangoAgro = 3;
    public int danioMOB = 0;
    public float distanciaDeAtaque = 2.0f;

    private Animator miAnimador;
    private Rigidbody2D miCuerpo;
    private GameObject heroeJugador;
    private EfectosSonoros misSonidos;
    private Personaje elPerso;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();

        heroeJugador = GameObject.FindGameObjectWithTag("Player");
        elPerso = heroeJugador.GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if (elPerso.estaVivo()) // Verifica si el personaje est� vivo
        {
            Vector3 miPos = this.transform.position;
            Vector3 posHeroe = heroeJugador.transform.position;
            float distanciaHeroe = (miPos - posHeroe).magnitude;

            if (distanciaHeroe < rangoAgro)
            {
                heroeCerca = true;

                if (heroeJugador.transform.position.x < this.transform.position.x)
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }

            if (distanciaHeroe < distanciaDeAtaque)
            {
                // Activa la animaci�n de ataque.
                miAnimador.SetTrigger("Golpear");
            }
            else
            {
                heroeCerca = false;
            }

            if (heroeCerca)
            {
                miCuerpo.velocity = transform.right * velocidadCaminar;
                miAnimador.SetBool("CAMINANDO", true);
            }
            else
            {
                miCuerpo.velocity = Vector3.zero;
                miAnimador.SetBool("CAMINANDO", false);
            }


        }

        else
        {
            heroeCerca = false;
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("CAMINANDO", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (elPerso.estaVivo()) // Verifica si el personaje est� vivo
        {
            GameObject otro = collision.gameObject;
            if (otro.tag == "Player")
            {
                print(name + " detect� colisi�n con " + otro);

                elPerso.hacerDanio(danioMOB, this.gameObject);
            }
        }
    }

}