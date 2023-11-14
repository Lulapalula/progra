using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private Vector3 lastCheckpointPosition; // Variable para almacenar la última posición del checkpoint

    void Start()
    {
        // Establecer la posición inicial o alguna posición predeterminada
        lastCheckpointPosition = new Vector3(0f, 0f, 0f);
    }

    // Llamado cuando el jugador toca un checkpoint
    public void SetCheckpoint(Vector3 checkpointPosition)
    {
        lastCheckpointPosition = checkpointPosition;
    }

    // Llamado cuando el jugador muere
    public void RespawnPlayer(Personaje suPersonaje)
    {
        if (!suPersonaje.estaVivo())
        {
            // Restablecer la posición del jugador en el último checkpoint
            suPersonaje.Respawn(lastCheckpointPosition);
        }
    }
}
