﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour

{
    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMinimas = 1;
    public int score = 0;
    private Animator miAnimador;
    private EfectosSonoros misSonidos;
    public bool bloqueado = false;

    public GameObject heridasPrefab;
    public GameObject vidasMenosPrefab;

    // Start is called before the first frame update
    void Start()
    {
        misSonidos = GetComponent<EfectosSonoros>();
        miAnimador = GetComponent<Animator>();
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
            miAnimador.SetTrigger("MUERTO");
            misSonidos.reproducir("muerte");
        }
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
            }

            bloqueado = true;
            print(name + " recibe da�o de " + puntosDanio + " por " + enemigo);
            bloqueado = true;
            GameObject efectoDanio = Instantiate(heridasPrefab);
            efectoDanio.transform.position = transform.position;
            miAnimador.SetTrigger("DAÑANDO");
            misSonidos.reproducir("daño");
            Invoke("desbloquear", 1.2f);

        }
    }


    public void instaKill(GameObject quien)
    {
        print(name + " murio intantaneamente " + quien);
        hp = 0;
        vidas = 0;
        vidasMinimas = 0;
        miAnimador.SetTrigger("MUERTO");
        misSonidos.reproducir("splash");
        misSonidos.reproducir("muerte");
    }

    public bool estaVivo()
    {
        return hp > 0;
    }
}
