using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int puntosAtaque = 30;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("MOB"))
        {
            // Verifica si la colisión ocurrió con el CapsuleCollider2D del enemigo
            CapsuleCollider2D enemigoCollider = otro.GetComponent<CapsuleCollider2D>();
            if (enemigoCollider != null && collision == enemigoCollider)
            {
                print(name + " detectó colisión con " + otro);

                Personaje elPerso = otro.GetComponent<Personaje>();

                if (elPerso != null)
                {
                    elPerso.hacerDanio(puntosAtaque, this.gameObject);
                }
            }
        }
    }
}