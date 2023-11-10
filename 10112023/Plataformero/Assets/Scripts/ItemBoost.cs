using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoost : MonoBehaviour
{
    private Animator miAnimador;
    private ControladorJugador elPerso;//sin esta cosa el metodo restaurar velocidad no sirve

    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

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

                elPerso = otro.GetComponent<ControladorJugador>();

                if (elPerso != null)
                {
                    elPerso.velocidadCaminar *= 2;
                    miAnimador.SetTrigger("Desaparece");
                    Invoke("restaurarVelocidad", 3);
                    Invoke("destruirObjeto", 3);
                }
            }
        }
    }


    public void restaurarVelocidad()
    {
        Debug.Log("Restaurando velocidad");//indica si el metodo fue llamado correctamente 
        if (elPerso != null)
        {
            elPerso.velocidadCaminar /= 2;//accede a los atributos de controlador jugador 
            Debug.Log("Nueva velocidad: " + elPerso.velocidadCaminar);//indica si se modifico la velocidad 
        }
    }


    public void destruirObjeto()
    {
        Destroy(gameObject);
        Debug.Log("objeto destruido");
    }
}