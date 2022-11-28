using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingRightPlayerState : IPlayerState
{
    //Player mPlayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering sliding right state");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.transform.localScale = new Vector3(2, 0.5f, 1);
        rbPlayer.velocity = new Vector3(5, 0, 0);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if(!Input.GetKey(KeyCode.S))
        {
            rbPlayer.transform.localScale = new Vector3(1, 1, 1);
            RunningRightPlayerState runningRightState = new RunningRightPlayerState();
            runningRightState.Enter(player);
        }
    }
}
