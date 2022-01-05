using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex7 : MonoBehaviour
{
    //각 월에 따른 한달간의 날짜 수를
    //알려주는 프로그램을 만들어주세요.
    //ex) 몇월이 궁금하세요? 7
    // 7월은 : 31일 까지 있습니다.

    string input = "1";
    

    void Start()
    {
        int month = int.Parse(input);

        switch (month)
        {
            case 1:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
            case 2:
                Debug.Log($"{month}월은 28일까지 있습니다.");
                break;
            case 3:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
            case 4:
                Debug.Log($"{month}월은 30일까지 있습니다.");
                break;
            case 5:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
            case 6:
                Debug.Log($"{month}월은 30일까지 있습니다.");
                break;
            case 7:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
            case 8:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
            case 9:
                Debug.Log($"{month}월은 30일까지 있습니다.");
                break;
            case 10:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
            case 11:
                Debug.Log($"{month}월은 30일까지 있습니다.");
                break;
            case 12:
                Debug.Log($"{month}월은 31일까지 있습니다.");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
