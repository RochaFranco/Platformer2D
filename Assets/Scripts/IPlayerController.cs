using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerController
{

    void Move(float velocity, Transform transform);

    bool Jump(bool canJump, float jumpForce, Rigidbody2D rb);


}
