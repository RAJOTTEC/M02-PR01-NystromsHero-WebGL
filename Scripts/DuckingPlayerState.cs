using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering ducking state");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.transform.localScale = new Vector3(1, 0.5f, 1);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if(!Input.GetKey(KeyCode.S))
        {
            rbPlayer.transform.localScale = new Vector3(1, 1, 1);
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}
