using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20211231_EX4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "15";
        string userInput2 = "30";
        string userInput3 = "45";

        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
        int c = int.Parse(userInput3);

        Debug.Log("�ִ밪 : " + Mathf.Max(a, b, c));
        Debug.Log("�ּҰ� : " + Mathf.Min(a, b, c));
        Debug.Log("�հ� : " + (a + b + c));
        Debug.Log("��� : " + (a+b+c/3));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
