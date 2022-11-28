using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningLeftPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering left running state");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.velocity = new Vector3(-10, 0, 0);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if(Input.GetKey(KeyCode.W))
        {
            SpeedingLeftPlayerState speedingLeftState = new SpeedingLeftPlayerState();
            speedingLeftState.Enter(player);
        }

        if(Input.GetKey(KeyCode.S))
        {
            SlidingLeftPlayerState slidingLeftState = new SlidingLeftPlayerState();
            slidingLeftState.Enter(player);
        }

        if(!Input.GetKey(KeyCode.A))
        {
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}
