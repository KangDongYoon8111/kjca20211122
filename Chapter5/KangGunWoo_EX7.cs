using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX7 : MonoBehaviour
{
//    각 월에 따른 한달간의 날짜 수를
//알려주는 프로그램을 만들어주세요.

    // Start is called before the first frame update
    void Start()
    {
        int month = 1;
        int lastDay = DateTime.DaysInMonth(2022, month);

        Debug.Log($"{month}월의 마지막 날은 {lastDay} 입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
