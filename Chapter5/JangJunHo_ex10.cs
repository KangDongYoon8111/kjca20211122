using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex10 : MonoBehaviour
{
    void Start()
    {
        /*string[] a = { "★☆☆☆☆", "★★☆☆☆", "★★★☆☆", "★★★★☆", "★★★★★" };
        for (int i = 0; i < 5; i++)
            Debug.Log(a[i]); 아무튼 답은 나오는 간단한 방법*/


        string a = "★";
        string b = "☆";
        string c = "";
        string d = "";
        for (int i = 0; i < 5; i++)
        {
            d += a;
            c += d;
            for (int k = 4; k > i; k--)
                c += b;

            Debug.Log(c);
            c = "";
        }
    }

}
