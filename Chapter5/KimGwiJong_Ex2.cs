using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        정수 한 개를 입력받아서,
        그 수가 50 이상의 수인지
        50미만의 수인지
        판단하는 프로그램을 만들어 주세요.
        */
        string input = "50";
        int integer1 = int.Parse(input);

        if(integer1>=50)
        {
            Debug.Log("50 이상입니다.");
        }
        else
        {
            Debug.Log("50 미만입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
