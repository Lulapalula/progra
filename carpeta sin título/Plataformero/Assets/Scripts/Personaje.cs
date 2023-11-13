using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMinimas = 1;
    public int score = 0;
    public int dinero = 0;
    public bool bloqueado = false;

    public GameObject[] items;
    public GameObject heridasPrefab;
    public GameObject vidasMenosPrefab;

    private Animator miAnimador;
    private EfectosSonoros misSonidos;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

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

        if (hp == 0 && vidas == 0 && tag == "MOB" && items.Length > 0)
        {
            Vector3 mobPosition = transform.position; // Cambiado a transform.position
            int randomIndex = Random.Range(0, items.Length);
            GameObject newItem = Instantiate(items[randomIndex], mobPosition, Quaternion.identity);
            Invoke("destruirObjeto", 0.5f);
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
        Debug.Log("Reiniciando la escena...");
        SceneManager.LoadScene("Level1");
    }

    private void destruirObjeto()
    {
        Destroy(gameObject);
    }
}

