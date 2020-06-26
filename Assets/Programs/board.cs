using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class board : MonoBehaviour
{
    paiBase pai;
    private GameObject[] yama;      // 山牌
    private GameObject[] wanpai;    // 王牌
    private GameObject[,] tehai;    // 手牌×4
    private GameObject[,] kawa;     // 河（捨て牌置き場）×４
    private List<GameObject> naki;  // 鳴きでとった牌を格納

    private int dice1, dice2;       // 王牌を決めるサイコロ
    private int[] paiSort;

    // Start is called before the first frame update
    board() {
        pai = new paiBase();                // paiBaseのインスタンス化
        yama = new GameObject[17 * 2 * 4];
        wanpai = new GameObject[7 * 2];
        tehai = new GameObject[4, 14];
        kawa = new GameObject[4, 100];// とりあえず100にしといた
        naki = new List<GameObject>();

        paiSort = new int[136];
    }

    // 開門する（王牌を決める）
     public void kaimen() {
        dice1 = UnityEngine.Random.Range(1, 7);
        dice2 = UnityEngine.Random.Range(1, 7);

        if(dice1 + dice2 < 7) {
            // 北家からとって来る処理
            // wanpai[]に格納
        } else {
            // 西家の右端からwanpai[]に格納
        }
     }
   
    // 洗牌
    public void shipai() {
        // 牌のシャッフル＆paiSort[]に格納
    }  
    
    // 配牌
    public void haibai() {
        // 王牌が終わった左から二組ずつ振り分ける
    }

}
