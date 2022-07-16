using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcPlayerController : IPlayerController
{

    public bool Jump(bool canJump, float jumpForce,Rigidbody2D rb)
    {
        if (Input.GetKey(KeyCode.Space) && canJump == true)
        {        
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            return false;
        }
        return true;
    }

    public void Move(float velocity, Transform transform)
    {
        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal") * velocity * Time.deltaTime, 0, 0);
    }

}
