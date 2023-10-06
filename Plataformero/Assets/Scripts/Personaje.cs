using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour

{
    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMinimas = 1;
    public int score = 0;

    public GameObject heridasPrefab;
    public GameObject vidasMenosPrefab;

    // Start is called before the first frame update
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        if (hp <= 0 && vidas > 0)
        {
            vidas--;
            hp = hpMax;

            GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);
            efectoVidasMenos.transform.position = transform.position;
        }
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
            }

            print(name + " recibe da�o de " + puntosDanio + " por " + enemigo);

            GameObject efectoDanio = Instantiate(heridasPrefab);
            efectoDanio.transform.position = transform.position;

        }
    }
    public void instaKill(GameObject quien)
    {
        print(name + " murio intantaneamente " + quien);
        hp = 0;
    }
}
