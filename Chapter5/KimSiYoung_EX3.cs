using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimSiYoung : MonoBehaviour
{
    // Start is called before the first frame update
    
    //문제2.
    //정수 한 개를 입력받아서,
    //그 수가 3의 배수인지
    //판단하는 프로그램을
    //만들어주세요.

    void Start()
    {
        string userInput = "30";
        int number = int.Parse(userInput);

        {
            if (number % 3 == 0)
            {
                Debug.Log("입력한 수는 3의 배수입니다.");
            }
            else
            {
                Debug.Log("입력한 수는 3의 배수가 아닙니다.");
            }

    }
}

    // Update is called once per frame
    void Update()
    {

    }
}
