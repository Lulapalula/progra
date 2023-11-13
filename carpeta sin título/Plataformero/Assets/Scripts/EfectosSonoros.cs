using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]//anotaciòn
public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource reproductor;

    private void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }

    public void reproducir(string accion)
    {
        foreach(Efecto e in misEfectos) 
        {
            //si la accion del efecto corresponde a la accion solicitada con el parametro
            if(e.accion == accion)
            {
                //asigno el sonido al reporductor (audiosource)
                reproductor.clip = e.sonido;
                reproductor.Play();
                //corto la ejecucion del metodo
                return;
            }
        }
    }

    [Serializable]

    public class Efecto//subclase
    {
        public string accion;
        public AudioClip sonido;
    }
}
