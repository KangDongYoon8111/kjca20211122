using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimYoungJoo20211228 : MonoBehaviour
{
    
    void Start()
    {
        string a = "30";
        string b = "40";

        print("사각형의 너비는 " + a + "입니다.");
        print("사각형의 너비는 " + b + "입니다.");

        int e = int.Parse(a);
        int f = int.Parse(b);

        int g = e * f;

        print("사각형의 넓이는: "+g);

    }


}
