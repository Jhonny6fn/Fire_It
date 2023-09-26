using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empezar_Juego : MonoBehaviour
{
    public GameObject Spawner, Menu, HUD;
    public static bool JuegoEmpezado;

    void Start()
    {
        JuegoEmpezado = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cara")
        {
            Spawner.SetActive(true);
            Menu.SetActive(false);
            HUD.SetActive(true);
            JuegoEmpezado = true;
        }
    }
}