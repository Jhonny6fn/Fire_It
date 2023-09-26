using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemy : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime, Space.World);
        transform.eulerAngles = new Vector3(0, 180, 0);

        if (destroy.death <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Cara")
        {
            Destroy(gameObject);
        }

        if (collision.tag == "wall")
        {
            Destroy(gameObject);
        }
    }
}