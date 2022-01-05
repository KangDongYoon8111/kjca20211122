using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJiHye2022010503 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
            정수 한 개를 입력받아서,
            그 수가 3의 배수인지
            판단하는 프로그램을
            만들어주세요.
        */
        string Userinput = "90";
        int a = int.Parse(Userinput);

        if (a % 3 == 0)
        {
            Debug.Log("3의 배수입니다.");
        }
        else
        {
            Debug.Log("3의 배수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
