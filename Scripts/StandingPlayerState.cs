using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entering standing state");
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            DuckingPlayerState duckingState = new DuckingPlayerState();
            duckingState.Enter(player);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            RunningRightPlayerState runningRightState = new RunningRightPlayerState();
            runningRightState.Enter(player);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            RunningLeftPlayerState runningLeftState = new RunningLeftPlayerState();
            runningLeftState.Enter(player);
        }
    }
}
