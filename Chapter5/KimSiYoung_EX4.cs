using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimSiYoung : MonoBehaviour
{
    // Start is called before the first frame update
    
    //사용자로부터 세 개의 정수를 입력받아,
    //그 수들의 최대값과 최소값, 
    //합계와 평균을 구하는 프로그램을
    //만들어주세요.
    
    void Start()
    {
        string a = "10";
        int num1 = int.Parse(a);

        string b = "20";
        int num2 = int.Parse(b);

        string c = "30";
        int num3 = int.Parse(c);

        //세개의 정수 중 최대값
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log("세 정수의 최대값은 " + $"{a}입니다.");
        }

        if (num2 > num3 && num2 > num1)
        {
            Debug.Log("세 정수의 최대값은 " + $"{b}입니다.");
        }

        if (num3 > num1 && num3 > num2)
        {
            Debug.Log("세 정수의 최대값은 " + $"{c}입니다.");
        }

        //세개의 정수 중 최소값
        if (num1 < num2 && num1 < num3)
        {
            Debug.Log("세 정수의 최소값은 " + $"{a}입니다.");
        }

        if (num2 < num3 && num2 < num1)
        {
            Debug.Log("세 정수의 최소값은 " + $"{b}입니다.");
        }

        if (num3 < num1 && num3 < num2)
        {
            Debug.Log("세 정수의 최소값은 " + $"{c}입니다.");
        }

        //세개의 정수의 합계와 평균
        Debug.Log("세 정수의 합계는 " + $"{num1 + num2 + num3}입니다.");
        Debug.Log("세 정수의 평균은 " + $"{(num1 + num2 + num3)/3}입니다.");

    }
        void Update()
    {


    }
}
