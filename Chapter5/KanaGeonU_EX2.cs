using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX2 : MonoBehaviour
{/*
    정수 한 개를 입력받아서,
    그 수가 50 이상의 수인지 
    50미만의 수인지
    판단하는 프로그램을 만들어 주세요.
    */
    // Start is called before the first frame update
    void Start()
    {
        int a = 50;

        if (a >= 50)
        {
            Debug.Log("50보다 크거나 같은 수");
        }
        else
        {
            Debug.Log("50보다 작은 수");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
