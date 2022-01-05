using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimSiYoung_ex7 : MonoBehaviour
{
    // Start is called before the first frame update
    
    //문제2.
    //각 월에 따른 한달간의 날짜 수를
    //알려주는 프로그램을 만들어주세요.
    //ex) 몇월이 궁금하세요? 7
    //7월은 : 31일 까지 있습니다.
    
    void Start()
    {
        string day = "2";

        Debug.Log("몇월이 궁금하세요?");
        Debug.Log(day);

        switch (day)
        {
            case "1":
            case "3":
            case "5":
            case "7":
            case "8":
            case "10":
            case "12":
                Debug.Log($"{day}월은 : 31일까지 있습니다.");
                break;

            case "2":
                Debug.Log($"{day}월은 : 28일까지 있습니다.");
                break;

            case "4":
            case "6":
            case "9":
            case "11":
                Debug.Log($"{day}월은 : 31일까지 있습니다.");
                break;

            default:
                Debug.Log($"{day}는(은) 요일이 아닙니다.");
               break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
