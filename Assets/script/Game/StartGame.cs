using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Menu;

    public void finalizarAnimacion()
    {
        Destroy(this.gameObject);
    }

    public void ActivarMenu()
    {
        Menu.SetActive(true);
    }
}