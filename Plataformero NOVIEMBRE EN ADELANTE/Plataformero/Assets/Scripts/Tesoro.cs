using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoro : MonoBehaviour
{
    private Animator miAnimador;
    private EfectosSonoros misSonidos;
    public int valor = 1;



    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject monedita = collision.gameObject;
        if (monedita.tag == "Player")
        {
            print(monedita + "agarró" + name);

            Personaje elPerso = monedita.GetComponent<Personaje>();
            misSonidos.reproducir("Recoger");
            miAnimador.SetTrigger("Adios");

            Destroy(gameObject, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
