using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 다음 코드에 Plus() 메소드가 float 형 매개변수를 지원하도록
    //오버로딩하세요.이 프로그램이 완성된 후의 실형 결과는 다음과 같아야 합니다.

    public static float Plus(float userInput1, float userInput2)
    {
        return userInput1 + userInput2;
    }
    private void Start()
    {
        int a = 1;
        int b = 2;

        float c = 3.4f;
        float d = 5.6f;

        Debug.Log($"{a} + {b} = {Plus(a, b)}");
        Debug.Log($"{c} + {d} = {Plus(c, d)}");
    }
}
