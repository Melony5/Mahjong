using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class paiBase : MonoBehaviour
{
    public static int PAIAll; // 牌全体の個数

    static public GameObject[,,] pai;   // 全ての牌ゲームオブジェクトを格納
    public enum kind{manzu, sozu, pinzu, sangen, fon};  // 牌の種類
    public enum num {one= 1, two, three, four, five, six, seven,
                     eight, nine, haku, hatsu, chun, east, south, west, north}; // 牌の数字
    static public int kindNum;  // 列挙型kindの要素数
    static public int numNum;   // 列挙型numの要素数
    public paiBase() {
    }

    static paiBase() {
        PAIAll = 136;

        kindNum = Enum.GetValues(typeof(kind)).Length;
        numNum = Enum.GetValues(typeof(num)).Length;

        pai = new GameObject[kindNum, 4, 9];
        
        //TODO: FindWithTag()はどんな順番でオブジェクトを取得してるかわかんない。順番通りに取得してたらいいんだけど...
        // テストしてない
        for (int i = 0; i < pai.GetLength(0); i++) {
            for(int j = 0; j <pai.GetLength(1); j++) {
                for(int k = 0; k < pai.GetLength(2); k++) {
                    switch (i) {
                        case (int)kind.manzu : pai[i, j, k] = GameObject.FindWithTag("manzu");  break;
                        case (int)kind.sozu  : pai[i, j, k] = GameObject.FindWithTag("sozu");   break;
                        case (int)kind.pinzu : pai[i, j, k] = GameObject.FindWithTag("pinzu");  break;
                        case (int)kind.sangen: pai[i, j, k] = GameObject.FindWithTag("sangen"); break;
                        case (int)kind.fon   : pai[i, j, k] = GameObject.FindWithTag("fon");    break;
                    } 
                }
            }
        }
    }
}
