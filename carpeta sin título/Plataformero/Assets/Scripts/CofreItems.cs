using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreItems : MonoBehaviour
{
    public bool contacto;
    private bool cofreAbierto;

    private Animator miAnimador;
    public GameObject chestButton;
    public GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        chestButton.SetActive(false); 
        cofreAbierto = false; 

        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && contacto == true)
        {
            miAnimador.SetTrigger("Abrir");


            Vector3 cofrePosition = transform.position; ; 
            GameObject newItem = Instantiate(itemPrefab, cofrePosition, Quaternion.identity); 
            cofreAbierto = true; 

            Invoke("destruirObjeto", 6);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {
           
            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();

            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);

                if (!cofreAbierto) 
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

