using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paiBase : MonoBehaviour
{
    private enum kind{ manzu, sozu, pinzu, sangen, fon};
    private enum num {ii = 1, ryan, san, su, uu, ro, chi, pa,
                      kyu, haku, hatsu, chun, ton, nan, sya, pe};

    GameObject[,] pai = new GameObject[5, 16];


    public GameObject getType(int type) {
        return pai[0, 0];
    }
}
