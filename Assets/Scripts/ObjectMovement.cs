using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public float vertical;
    public float horizontal;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(0,vertical,0);
        transform.position = transform.position + new Vector3(horizontal, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bajar")
        {
            vertical = -0.005f;
        }

        if (collision.gameObject.tag == "Subir")
        {
            vertical = 0.005f;
        }

        if (collision.gameObject.tag == "Izquierda")
        {
            horizontal = -0.005f;
        }

        if (collision.gameObject.tag == "Derecha")
        {
            horizontal = 0.005f;
        }
    }


}
