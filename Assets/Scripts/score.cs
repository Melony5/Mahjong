using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    //クラスの中に入れるべきなのかどうかもわからない.ファイルすら分けるべきかも
    //向聴数(あがりやリーチまでの数)
    //国士無双の場合

    //任意の手牌とその次とが対子どうかを調べて真偽を返す
    bool CheckToitu(int[] syuhai,int i) {
        if (syuhai[i] == syuhai[i + 1]) return true;
        else return false;
    }
        
    int SyantenKokusiMusou(int[]syuhai) {//intにするかどうかも決まってない,引数も決まってない
        int syanten = 13;
        bool toitu = false;
       
        for (int i = 0; i < 13; i++) {
            //手牌の種類(一九字牌)を数える
            toitu = CheckToitu(syuhai, i);
            if (CheckToitu(syuhai, i) == true /*"かつ19字牌だったら"*/) syanten--;
            syanten--;
        }
        return syanten;//向聴数を返す
    }
        //七対子の場合

    int SyantenTitoi() {
        int syanten = 0;
        int toitu = 0;
        for(int i = 0; i < 13; i++) {
            //七対子の向聴数=6-対子の数(例外処理もある)
            toitu++;
        }
        return syanten;
    }
        //一般の場合
    }
