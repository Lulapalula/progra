using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float fuerzaSalto = 10;
    public float velocidadCaminar = 5;
    public int contador = 2;
    public bool enPiso = false;

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private EfectosSonoros misSonidos;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();//invocacion del componente 
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        detectarPiso();

        if (movHoriz > 0)
        {//se mueve a la dere
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);

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

        void detectarPiso()
        {
            enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);//desde donde, en que direccion, que tan largo 
        }

        

        if (Input.GetButtonDown("Jump") && (enPiso || contador > 0))
        {
            miCuerpo.velocity = new Vector2(miCuerpo.velocity.x, fuerzaSalto);
            contador--; // Aumentar el contador cuando salta

            misSonidos.reproducir("salto");
        }

        if (enPiso)
        {
            contador = 1; // Restablecer el contador cuando toca el suelo
        }

    }
}
