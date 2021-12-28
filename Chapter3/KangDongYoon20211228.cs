using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangDongYoon20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        // 이 곳에 사각형의 넓이를 계산하고
        // 출력하는 코드를 추가하세요.

        Debug.Log("사각형의 너비는 "+a+ "입니다.");
        Debug.Log($"사각형의 너비는 {a} 입니다.");

        Debug.Log("사각형의 높이는 " + b + "입니다.");
        Debug.Log($"사각형의 높이는 {b} 입니다.");

        int f = int.Parse(a);
        int g = int.Parse(b);
        int h = f * g;

        Debug.Log("사각형의 넓이는 : " + h);
        Debug.Log($"사각형의 넓이는 : {h}");

        Debug.Log("사각형의 넓이는 : " + f*g);
        Debug.Log($"사각형의 넓이는 : {f*g}");

        Debug.Log("사각형의 넓이는 : " + int.Parse(a)*int.Parse(b));
        Debug.Log($"사각형의 넓이는 : {int.Parse(a) * int.Parse(b)}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
