using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState
{
    void EnterState(PlayerMovement player);
    void UpdateState(PlayerMovement player);
    void ExitState(PlayerMovement player);
}
