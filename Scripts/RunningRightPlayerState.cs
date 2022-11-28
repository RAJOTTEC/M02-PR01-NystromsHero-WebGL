using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningRightPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering right running state");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.velocity = new Vector3(10, 0, 0);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if(Input.GetKey(KeyCode.W))
        {
            SpeedingRightPlayerState speedingRightState = new SpeedingRightPlayerState();
            speedingRightState.Enter(player);
        }
        
        if(Input.GetKey(KeyCode.S))
        {
            SlidingRightPlayerState slidingRightState = new SlidingRightPlayerState();
            slidingRightState.Enter(player);
        }

        if(!Input.GetKey(KeyCode.D))
        {
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}
