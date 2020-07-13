using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class board : MonoBehaviour
{
    paiBase pai;
    public static int playerNum;        // プレイヤー数
    public static int wanpaiNum;        // 王牌の数
    private List<GameObject> yama;      // 山牌
    private List<GameObject>[] tehai;   // 手牌

    private GameObject[] wanpai;    // 王牌
    private GameObject[,] kawa;     // 河（捨て牌置き場）×４
    private List<GameObject> naki;  // 鳴きでとった牌を格納

    private int dice1, dice2;       // 王牌を決めるサイコロ
    private int[] yamaTemp;
    private int parent;

    System.Random yamaInit;

    static board() {
        playerNum = 4;
        wanpaiNum = 2 * 7;
    }

    // Start is called before the first frame update
    board() {
        pai = new paiBase();                // paiBaseのインスタンス化
        yama = new GameObject[17 * 2 * 4];
        wanpai = new GameObject[7 * 2];
        tehai = new GameObject[4, 14];
        kawa = new GameObject[4, 100];// とりあえず100にしといた
        naki = new List<GameObject>();

        yamaTemp = new int[136];

        for(int i = 0; i < 136; i++) {
            yamaTemp[i] = i;
        }

        yamaInit = new System.Random();
    }

    // 開門する（王牌を決める）
     public void kaimen() {
        dice1 = UnityEngine.Random.Range(1, 4);

        //TODO: ここでサイコロとかを見せる演出があるといい

        if(dice1 + dice2 < 7) {

            // 北家からとって来る処理
            // wanpai[]に格納
        } else {
            // 西家の右端からwanpai[]に格納
        }
     }
   
    // 洗牌
    public void shipai() {
        // 牌のシャッフルyama[]に格納
        int yamaLen = yamaTemp.Length;

        while(yamaLen > 1) {
            yamaLen--;
            int k = yamaInit.Next(yamaLen + 1);

            int temp = yamaTemp[k];
            yamaTemp[k] = yamaTemp[yamaLen];
            yamaTemp[yamaLen] = temp;
        }

        for(int i = 0; i < 5; i++) {
            for(int j = 0; j < 4; j++) {
                for(int k = 0; k < 9; k++) {
                    yama[yamaTemp[i]] = paiBase.pai[i, j, k];
                }
            }
        }
    }  
    
    // 配牌
    public void haibai() {
        // 王牌が終わった左から二組ずつ振り分ける
    }

}
