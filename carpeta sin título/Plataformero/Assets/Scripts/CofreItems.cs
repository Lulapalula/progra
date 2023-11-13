using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreItems : MonoBehaviour
{
    public bool contacto;
    private bool cofreAbierto; //Si el cofre esta abierto o no

    private Animator miAnimador;
    public GameObject chestButton;
    public GameObject itemPrefab; // GameObject para aceptar cualquier prefab

    // Start is called before the first frame update
    void Start()
    {
        chestButton.SetActive(false); //desactiva el sprite de botton del guid
        cofreAbierto = false; 

        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && contacto == true)
        {
            miAnimador.SetTrigger("Abrir");


            Vector3 cofrePosition = transform.position; ; //calcula la posicion del cofre
            GameObject newItem = Instantiate(itemPrefab, cofrePosition, Quaternion.identity); //instanciar el prefab en la posicion del player 
            
            cofreAbierto = true; // si se presiono fire 1 se abre el cofre 

            Invoke("destruirObjeto", 6);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {
            // Verifica si la colisión ocurrió con el CapsuleCollider2D del jugador
            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();

            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);

                if (!cofreAbierto)//si el cofre no esta abierto salta el botton del guid, si esta abierno entonces no 
                {
                    chestButton.SetActive(true);
                    contacto = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        chestButton.SetActive(false);
        contacto = false;
    }

    public void destruirObjeto()
    {
        Destroy(gameObject);
        Debug.Log("objeto destruido");
    }
}

