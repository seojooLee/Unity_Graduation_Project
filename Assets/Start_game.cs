using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_game : PlayTimer
{

    PlayTimer play = new PlayTimer();
    public void OnTriggerEnter(Collider player)
    {

        if (player.gameObject.tag == "Player")
        {
            Debug.Log("START_POINT APPROACH");
            PlayTimer.real_time = true;
        }
    }
}
