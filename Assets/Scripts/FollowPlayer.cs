using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if (player == null)
        {
            transform.position = transform.localPosition;
        }

        transform.position = new Vector3(player.transform.position.x,0,0);

        
    }
}
