using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex3 : MonoBehaviour
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
        string input = "30";
        int integer1 = int.Parse(input);

        if (integer1 % 3 == 0)
        {
            Debug.Log("3의 정수입니다.");
        }
        else
        {
            Debug.Log("3의 정수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
