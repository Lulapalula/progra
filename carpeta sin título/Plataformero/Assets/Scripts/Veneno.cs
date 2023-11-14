using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public int danio;
    public float duracion;
    private bool posionUsada;

    private Personaje elPerso;
    private Animator miAnimador;


    // Start is called before the first frame update
    void Start()
    {
        posionUsada = false;
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
            posionUsada = true;

            print(name + "detecte colision con" + collision.gameObject);
            

            elPerso = otroObjeto.GetComponent<Personaje>();

            if (posionUsada == true)
            {
                
                InvokeRepeating("danioVeneno", 0, 1);
                miAnimador.SetTrigger("Desaparece");
                Invoke("destruirObjeto", duracion);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        posionUsada = false;
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
