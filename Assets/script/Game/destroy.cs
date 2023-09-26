using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public static float death = 5;
    public GameObject GameOverCanvas, Spawner, HUD;
    public GameObject Corazon1, Corazon2, Corazon3, Corazon4, Corazon5;
    public AudioSource Musica, GameOver;

    void Update()
    {
        if(death == 5)
        {
            Corazon1.SetActive(true);
            Corazon2.SetActive(true);
            Corazon3.SetActive(true);
            Corazon4.SetActive(true);
            Corazon5.SetActive(true);
        }

        if (death == 4)
        {
            Corazon1.SetActive(true);
            Corazon2.SetActive(true);
            Corazon3.SetActive(true);
            Corazon4.SetActive(true);
            Corazon5.SetActive(false);
        }

        if (death == 3)
        {
            Corazon1.SetActive(true);
            Corazon2.SetActive(true);
            Corazon3.SetActive(true);
            Corazon4.SetActive(false);
            Corazon5.SetActive(false);
        }

        if (death == 2)
        {
            Corazon1.SetActive(true);
            Corazon2.SetActive(true);
            Corazon3.SetActive(false);
            Corazon4.SetActive(false);
            Corazon5.SetActive(false);
        }

        if (death == 1)
        {
            Corazon1.SetActive(true);
            Corazon2.SetActive(false);
            Corazon3.SetActive(false);
            Corazon4.SetActive(false);
            Corazon5.SetActive(false);
        }

        if (death == 0)
        {
            Corazon1.SetActive(false);
            Corazon2.SetActive(false);
            Corazon3.SetActive(false);
            Corazon4.SetActive(false);
            Corazon5.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            death--;
           
            if (death <= 0)
            {
                Spawner.SetActive(false);
                HUD.SetActive(false);
                Musica.volume = 0.3f;
                GameOver.Play();
                GameOverCanvas.SetActive(true);
            }
        }
    }
}