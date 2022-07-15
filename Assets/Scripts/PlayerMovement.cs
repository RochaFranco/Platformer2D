using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float velocity;
    public float jumpForce;
    public bool canJump;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

        transform.position = transform.position + new Vector3 (Input.GetAxis("Horizontal") * velocity * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.Space) && canJump == true)
        {
            canJump = false;
            rb.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = true;
        }

        if (collision.gameObject.tag == "death")
        {
            Destroy(gameObject);
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bajar")
        {
            Debug.Log("Gordito pasaste por un trigger");
        }
    }
}
