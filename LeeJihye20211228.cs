using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJihye20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        int d = int.Parse(a);
        int e = int.Parse(b);

        int c = (d * e);

        Debug.Log("사각형의 너비는"); Debug.Log ("a");  Debug.Log("입니다.");
        Debug.Log (c);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
