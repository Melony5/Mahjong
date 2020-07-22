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
    public static int tehaiNum;

    private List<GameObject> yama;      // 山牌
    private List<GameObject>[] tehai;   // 手牌
    private List<GameObject>[] kawa;    // 河（捨て牌置き場）×４
    private List<GameObject>[] naki;  // 鳴きでとった牌を格納

    private GameObject[] wanpai;    // 王牌

    private int parent;

    static board() {
        playerNum = 4;
        wanpaiNum = 2 * 7;
        tehaiNum = 13;
    }

    // Start is called before the first frame update
    board() {
        yama = new List<GameObject>();
        tehai = new List<GameObject>[playerNum];
        kawa = new List<GameObject>[playerNum];
        naki = new List<GameObject>[playerNum];
        wanpai = new GameObject[wanpaiNum];
    }

    public void PaiSort(int[] array, int size) {
        int index;
        List<int[]> count = new List<int[]>();
        int i = 0;

        for(i = 0; i < paiBase.kindNum; i++) {
            for(int j = 0; j < playerNum; j++) {
                for(int k = 0; k < paiBase.numNum; i++) {
                    count.Add(new int[3] { i, j, k });
                }
            }
        }
        i = 0;
        while(count.Count > 0) {
            index = UnityEngine.Random.Range(0, paiBase.PAIAll);

            yama[i] = paiBase.pai[count[index][0], count[index][1], count[index][2]];   //TODO: リストの要素の配列の中の要素の参照の仕方
            count.RemoveAt(index);
        }
    } 

    // 開門する（王牌を決める）
     public void kaimen() {
        for(int i = 0; i < wanpaiNum; i++) {
            wanpai[i] = yama[i];    // ランダムにソートされた山から先頭の14個を王牌にする
        }
     }
   
    // 配牌
    public void haibai() {
        for(int i = 0; i < playerNum; i++) {
            for(int j = 0; j < tehaiNum; i++) {
                tehai[i].Add(yama[i]);
                yama.RemoveAt(i);
            }
        }
        // 王牌が終わった左から二組ずつ振り分ける
    }

}
