using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohsangmok_ex1 : MonoBehaviour
{
    string userInput1 = "3";
    string userInput2 = "34.2";

    // Start is called before the first frame update
    void Start()
    { 

        {
            Debug.Log("���:" + userInput1 + "�� ��������" + a() + "�Դϴ�.");
            Debug.Log("���:" + userInput2 + "�� ��������" + b() + "�Դϴ�.");
        }
        int a()
        {
            int a = int.Parse(userInput1);
            a *= a;
            return a;
        }
        float b()
        {
            float b = float.Parse(userInput2);
            b *= b;
            return b;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
