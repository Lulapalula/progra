using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private EfectosSonoros misSonidos;
    private GameManager gameManager;

    void Start()
    {
        misSonidos = GetComponent<EfectosSonoros>();
        gameManager = FindObjectOfType<GameManager>(); // Asegúrate de que solo haya un GameManager en la escena
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {
            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();

            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);

                Personaje elPerso = otro.GetComponent<Personaje>();

                if (elPerso != null)
                {
                    // Guardar la posición del checkpoint en el GameManager
                    gameManager.SetCheckpoint(transform.position);

                    // Reproducir el sonido
                    misSonidos.reproducir("TocarCheckpoint");

                    // Destruir el objeto después de 2 segundos
                    Invoke("destruirObjeto", 2f);
                }
            }
        }
    }

    private void destruirObjeto()
    {
        Destroy(gameObject);
    }
}


