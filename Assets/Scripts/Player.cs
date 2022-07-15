using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float velocity;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    bool canJump;
    IPlayerController controller;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = new PcPlayerController();
    }

    void Update()
    {
        controller.Move(velocity, transform);

        if (canJump == true)
        {
            canJump = controller.Jump(canJump, jumpForce, rb);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = true;
            Debug.Log("Toco el suelo");
        }

        if (collision.gameObject.tag == "death")
        {
            Destroy(gameObject);
        }
    }
}
