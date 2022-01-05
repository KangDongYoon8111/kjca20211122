using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220104_EX7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "7";
        int month = int.Parse(userInput);

        Debug.Log("몇월이 궁금하세요? :"+month);

        switch (month)
        {
            case 1:
                Debug.Log("1월은 : 31일까지 있습니다.");
                break;
            case 2:
                Debug.Log("2월은 : 28일까지 있습니다.");
                break;
            case 3:
                Debug.Log("3월은 : 31일까지 있습니다.");
                break;
            case 4:
                Debug.Log("4월은 : 30일까지 있습니다.");
                break;
            case 5:
                Debug.Log("5월은 : 31일까지 있습니다.");
                break;
            case 6:
                Debug.Log("6월은 : 30일까지 있습니다.");
                break;
            case 7:
                Debug.Log("7월은 : 31일까지 있습니다.");
                break;
            case 8:
                Debug.Log("8월은 : 31일까지 있습니다.");
                break;
            case 9:
                Debug.Log("9월은 : 30일까지 있습니다.");
                break;
            case 10:
                Debug.Log("10월은 : 31일까지 있습니다.");
                break;
            case 11:
                Debug.Log("11월은 : 30일까지 있습니다.");
                break;
            case 12:
                Debug.Log("12월은 : 31일까지 있습니다.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
