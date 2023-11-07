using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGUI : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHPHeroe;
    public Image barraHPHeroe;
    public Text scoreHeroe;
    public Text vidasHeroe;
    public Text monedasHeroe;

    public Personaje villano;
    public Text etiquetaHPVillano;
    public Image barraHPVillano;
    public RectTransform barraHPVillanoTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //muestro en el texto el hp del heroe
        etiquetaHPHeroe.text = heroe.hp + "/" + heroe.hpMax;

        //calculo de porcentaje de hp que le queda al cavernicola
        float porcentajeHPHeroe = heroe.hp / (float)heroe.hpMax;

        barraHPHeroe.fillAmount = porcentajeHPHeroe;

        // Muestro las vidas del h�roe
        vidasHeroe.text = heroe.vidas.ToString(); // Convierte el entero a cadena

        // Muestro el score del h�roe
        scoreHeroe.text = heroe.score.ToString(); // Convierte el entero a cadena

        monedasHeroe.text = heroe.monedas.ToString(); // Convierte el entero a cadena

        //muestro en el texto el hp del villano 
        etiquetaHPVillano.text = villano.hp + "/" + villano.hpMax;

        //calculo el porcentaje de hp que le queda al vilano
        float porcentajeHPVillano = villano.hp / (float)villano.hpMax;

        barraHPVillano.fillAmount = porcentajeHPVillano;

        //if (villano != null && barraHPVillanoTransform != null)
        //{
            // Obtiene la posici�n del villano en el mundo del juego
           // Vector3 villanoWorldPosition = villano.transform.position;

            // Convierte la posici�n del mundo en la posici�n de la pantalla
            //Vector2 screenPosition = Camera.main.WorldToScreenPoint(villanoWorldPosition);

            // Establece la posici�n de la barra de vida para que est� vinculada a la posici�n del villano en la pantalla
            //barraHPVillanoTransform.position = screenPosition;
        //}
    }
}
