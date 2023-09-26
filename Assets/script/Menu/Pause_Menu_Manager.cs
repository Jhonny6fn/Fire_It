using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu_Manager : MonoBehaviour
{
    public GameObject MenuDePausa, Camara, HUD;
    public AudioSource Musica;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Empezar_Juego.JuegoEmpezado == true)
        {
            MenuDePausa.SetActive(true);
            Time.timeScale = 0;
            Camara.SetActive(false);
            HUD.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Musica.volume = 0.3f;
        }
    }

    public void Continuar()
    {
        MenuDePausa.SetActive(false);
        Time.timeScale = 1;
        Camara.SetActive(true);
        HUD.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Musica.volume = 0.6f;
    }

    public void MenuExit()
    {
        Application.Quit();
    }
}