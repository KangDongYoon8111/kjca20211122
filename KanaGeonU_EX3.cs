using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX3 : MonoBehaviour
{
//    정수 한 개를 입력받아서,
//그 수가 3의 배수인지
//판단하는 프로그램을
//만들어주세요.
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        if(a%3 == 0)
        {
            Debug.Log("3의 배수");
        }
        else
        {
            Debug.Log("3의 배수가 아닙니다");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
