using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    paiBase pai;
    board board;
    score judge;

    int syanten;
    bool reach;
    bool agari;

    player() {
        pai = new paiBase();
        board = new board();
        judge = new score();
        reach = false;
        agari = false;
    }

    public bool move(int playerTurn) {
        tehai(playerTurn);
        if(reach == true) { // 立直の時の処理
            // 山から牌をとってきて、scoreクラスに渡す
        } else {
            score(playerTurn);
        }

        return agari;
    }

    // プレイヤーに取捨選択させてgetsetする。
    public void tehai(playerTurn) {
        // board.山のリスト型 これで山参照
        // 捨てる牌をクリっくさせる。
        // board.kawaにsetする。
    }

    public void score(playerTurn) {
        // scoreクラスをインスタンス化してやってもらう
        syanten = judge.agari();

        if(syanten == 0) {
            reach = true;
        }
    }
}
