using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuegoController : MonoBehaviour
{
    DeteccionCara faceDetector_2;

    public int RandomParticulas;
    public GameObject Particulas1;
    public GameObject Particulas2;
    public GameObject Particulas3;
    public GameObject Particulas4;
    public GameObject Particulas5;

    public static int NumeroPuntuacion;
    [SerializeField] Text Puntuacion;
    [SerializeField] Text Puntuacion_Score;

    public AudioSource MuerteEnemigo;

    void Start()
    {
        faceDetector_2 = (DeteccionCara)FindObjectOfType(typeof(DeteccionCara));
    }

    void Update()
    {
        transform.position = new Vector3(-((faceDetector_2.faceX - 450f) / 90), transform.position.y, (-faceDetector_2.faceY / 120) - 3.5f);

        RandomParticulas = Random.Range(0, 5);
        Puntuacion.text = NumeroPuntuacion.ToString("0");
        Puntuacion_Score.text = NumeroPuntuacion.ToString("0");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "enemy")
        {
            NumeroPuntuacion ++;
            MuerteEnemigo.Play();

            if (RandomParticulas == 0)
            {
                Instantiate(Particulas1, transform.position, Quaternion.identity);
            }
            if (RandomParticulas == 1)
            {
                Instantiate(Particulas2, transform.position, Quaternion.identity);
            }
            if (RandomParticulas == 2)
            {
                Instantiate(Particulas3, transform.position, Quaternion.identity);
            }
            if (RandomParticulas == 3)
            {
                Instantiate(Particulas4, transform.position, Quaternion.identity);
            }
            if (RandomParticulas == 4)
            {
                Instantiate(Particulas5, transform.position, Quaternion.identity);
            }
        }
    }
}