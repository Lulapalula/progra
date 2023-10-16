
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]
public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource reproductor;


     void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }
    public void reproducir(string accion)
    {
        foreach(Efecto e in misEfectos)
        {
            //si la acciòn del efecto corresponde as la accion solicitada en el parametro
            if (e.accion == accion)
            {
                //asigno el sonido al reproductor
                reproductor.clip = e.sonido;
                reproductor.Play();

                return;
            }
        }
    }


    [Serializable]
    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }

}
