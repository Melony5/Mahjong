using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public int playerTurn;
    player play;

    bool agari;
    // Start is called before the first frame update
    void Start()
    {
        play = new player();
        playerTurn = 1;

        agari = false;
    }

    // Update is called once per frame
    void Update()
    {
        agari = play.move(playerTurn);

        if(agari == true) {
            // スコア計算
            // 結果表示画面
        }
        
        if(playerTurn == 4) {
            playerTurn = 1;
        } else {
            playerTurn++;
        }
    }
}
