using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Personaje : MonoBehaviour

{
    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMinimas = 1;
    public int score = 0;
    public int dinero = 0;
    public bool bloqueado = false;

    

    public GameObject heridasPrefab;
    public GameObject vidasMenosPrefab;
   

    private Animator miAnimador;
    private EfectosSonoros misSonidos;

    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();

        

    }
    // Update is called once per frame
    void Update()
    {
        if (vidas == 0 && hp == 0 && tag == "Player")
        {
            Invoke("reiniciarEscena", 3.0f);
        }
    }

    public bool estaVivo()
    {
        return hp > 0;
    }
    private void desbloquear()
    {
        bloqueado = false;
    }

    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        if (vidas >= vidasMinimas)
        {
            if (hp <= puntosDanio)
            {
                hp = 0;
            }

            else
            {
                hp -= puntosDanio;
                bloqueado = true;
                //Dentro DE 1.2 SEG se ejecuta el metodo debloquear
                Invoke("desbloquear", 1);

                miAnimador.SetTrigger("Daño");
                misSonidos.reproducir("Daño");
            }

            print(name + " recibe danio de " + puntosDanio + " por " + enemigo);

            GameObject efectoDanio = Instantiate(heridasPrefab);
            efectoDanio.transform.position = transform.position;

            if (hp <= 0 && vidas > 0)
            {
                vidas--;
                hp = hpMax;

                GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);
                efectoVidasMenos.transform.position = transform.position;

                miAnimador.SetTrigger("Muerte");
                misSonidos.reproducir("Dead");

            }

            if (vidas <= 0)
            {
                miAnimador.SetTrigger("Muerte");
                misSonidos.reproducir("Dead");

            }

        }

    }
    public void instaKill(GameObject quien)
    {
        print(name + " murio intantaneamente " + quien);
        hp = 0;

        if (vidas > 0)
        {
            vidas = 0;
            hp = 0;
            GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);
            efectoVidasMenos.transform.position = transform.position;
            miAnimador.SetTrigger("Muerte");
            misSonidos.reproducir("Dead");
        }

    }

    private void reiniciarEscena()
    {
        // Recarga la escena actual para reiniciar el juego.
        Debug.Log("Reiniciando la escena...");
        SceneManager.LoadScene("Level1");
    }

    
}
