using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ohsangmok20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";
        

        Debug.Log("사각형의 너비는 " + a + "입니다.");
        Debug.Log("사각형의 높이는 " + b + "입니다.");

        int f = int.Parse(a);
        int g = int.Parse(b);
        int h = f * g;

        Debug.Log("사각형의 넓이는 : " + h);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
