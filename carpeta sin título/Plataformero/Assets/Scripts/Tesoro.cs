using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoro : MonoBehaviour
{
    public int valor = 1;

    private Animator miAnimador;
    private EfectosSonoros misSonidos;


    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {
            // Verifica si la colisión ocurrió con el CapsuleCollider2D del jugador
            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();

            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);

                Personaje elPerso = otro.GetComponent<Personaje>();

                if (elPerso != null)
                {
                    elPerso.dinero += valor;
                    miAnimador.SetTrigger("Tomar");
                    misSonidos.reproducir("Tomar");
                    Invoke("destruirObjeto", 0.6f);
                }
            }
        }
    }

    private void destruirObjeto()
    {
        Destroy(gameObject);
    }
}

