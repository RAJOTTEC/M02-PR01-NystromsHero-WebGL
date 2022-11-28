using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedingRightPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering speeding right state");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.transform.localScale = new Vector3(2, 1, 1);
        rbPlayer.velocity = new Vector3(20, 0, 0);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if(!Input.GetKey(KeyCode.W))
        {
            rbPlayer.transform.localScale = new Vector3(1, 1, 1);
            RunningRightPlayerState runningRightState = new RunningRightPlayerState();
            runningRightState.Enter(player);
        }
    }
}
