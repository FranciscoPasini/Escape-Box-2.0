using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IPlayerState
{
    public void EnterState(PlayerMovement player)
    {

    }

    public void UpdateState(PlayerMovement player)
    {
        float moveInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(moveInput) > 0.1f)
        {
            player.SetState(new MovingState());
        }

        if (player.isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            player.SetState(new JumpingState());
        }
    }

    public void ExitState(PlayerMovement player)
    {
    }
}
