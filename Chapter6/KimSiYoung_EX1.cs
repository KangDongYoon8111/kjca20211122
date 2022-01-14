using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    //다음 코드에 Plus() 메소드가 float 형 매개변수를 지원하도록
    //오버로딩하세요.이 프로그램이 완성된 후의 실형 결과는 다음과
    //같아야 합니다.

    public string userInput1 = "2";
    public string userInput2 = "24.2";

    void Start()
    {

    int a()
    {
            int num = int.Parse(userInput1);
            num *= num;
            return num;
    }

    float b()
    {
            float num2 = float.Parse(userInput2);
            num2 *= num2;
            return num2;
    }

    {
            Debug.Log("결과 : " + userInput1 + " 의 제곱값은 " + a() + " 입니다.");
            Debug.Log("결과 : " + userInput2 + " 의 제곱값은 " + b() + " 입니다.");
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
