using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private Vector3 lastCheckpointPosition; // Variable para almacenar la �ltima posici�n del checkpoint

    void Start()
    {
        // Establecer la posici�n inicial o alguna posici�n predeterminada
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
            // Restablecer la posici�n del jugador en el �ltimo checkpoint
            suPersonaje.Respawn(lastCheckpointPosition);
        }
    }
}
