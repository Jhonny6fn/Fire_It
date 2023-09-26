using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reiniciar_Juego : MonoBehaviour
{
    public GameObject MenuGameOver, HUD, Spawner;
    public AudioSource Musica;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cara")
        {
            destroy.death = 5;
            FuegoController.NumeroPuntuacion = 0;
            MenuGameOver.SetActive(false);
            HUD.SetActive(true);
            Spawner.SetActive(true);
            Musica.volume = 0.6f;
        }
    }
}