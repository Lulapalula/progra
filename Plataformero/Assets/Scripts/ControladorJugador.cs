using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{

    public float velocidadCaminar = 5;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();//invocacion del componente 
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)
        {//se mueve a la dere
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);//velocidad en esa direccion 

            miAnimador.SetBool("CAMINANDO", true);
        }

        else if (movHoriz < 0)
        {//se mueve a la iz1
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }

        else
        {//no se mueve
            miCuerpo.velocity = new Vector3(0, velVert, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }
    }
}
