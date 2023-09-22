using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraDeJugador : MonoBehaviour
{
    public Transform Cavernicola;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
           Cavernicola.position.x, //pos x
           Cavernicola.position.y, //pos y
           -1); //pos z
    }
}
