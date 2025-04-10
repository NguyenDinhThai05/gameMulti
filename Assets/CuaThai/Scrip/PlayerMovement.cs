using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    public CharacterController controller;
    public float Speed = 12f;

    public override void FixedUpdateNetwork()
    {
        if (!Object.HasStateAuthority)
            return;
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        var move = transform.right * x + transform.forward * z;
        controller.Move(move * Speed * Time.fixedDeltaTime);
    }
    
}
