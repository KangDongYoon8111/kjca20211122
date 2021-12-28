using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        int c = int.Parse(a);
        int d = int.Parse(b);
        

        Debug.Log($"사각형의 너비는"+a+"입니다.");
        Debug.Log($"사각형의 높이는" + b + "입니다.");
        Debug.Log($"사각형의 넓이는"+ c*d +"입니다.");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
