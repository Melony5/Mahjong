using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public int playerTurn;
    player play;
    // Start is called before the first frame update
    void Start()
    {
        playerTurn = 1;
        play = new player();
    }

    // Update is called once per frame
    void Update()
    {
        play.move(playerTurn);
        
        if(playerTurn == 4) {
            playerTurn = 1;
        } else {
            playerTurn++;
        }
    }
}
