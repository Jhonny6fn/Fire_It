using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir_Juego : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cara")
        {
            Application.Quit();
        }
    }
}