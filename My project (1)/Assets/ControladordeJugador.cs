using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladordeJugador : MonoBehaviour
{
    private RigigidBody Micuerpo;
    private Animator MiAnimador;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<RiggidBody2D>();
        MiAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = MiCuerpo.velocity.y;
        MiCuerpo.velocity = 
            new Vector3(5, velVert , 0);
        Mianimador.SetBool("CAMINANDO", true);
    }
}
