using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    //クラスの中に入れるべきなのかどうかもわからない.ファイルすら分けるべきかも
    //向聴数(あがりやリーチまでの数)
    //国士無双の場合
    int SyantenKokusiMusou() {//intにするかどうかも決まってない,引数も決まってない
        int syanten;
        for (int i = 0; i < 13; i++) {
            //手牌の種類(一九字牌)を数える
            syanten++;
        }
        return syanten;//向聴数を返す
    }
        //七対子の場合

    int SyantenTitoi() {
        int syanten;
        for(int i = 0; i < 13; i++) {
            //七対子の向聴数=6-対子の数(例外処理もある)
            syanten++;
        }
        return syanten;
    }
        //一般の場合
    }
}
