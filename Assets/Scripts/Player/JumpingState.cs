using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IPlayerState
{
    public void EnterState(PlayerMovement player)
    {
        player.Jump();
    }

    public void UpdateState(PlayerMovement player)
    {
        if (player.isGrounded)
        {
            player.SetState(new IdleState());
        }
    }

    public void ExitState(PlayerMovement player)
    {

    }
}
