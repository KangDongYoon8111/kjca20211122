using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_EX2 : MonoBehaviour
{
    /*
2. 다음 코드에 Plus() 메소드가 float 형 매개변수를 지원하도록
오버로딩하세요.이 프로그램이 완성된 후의 실형 결과는 다음과
같아야 합니다.
※ 결과(코드는 다음 페이지에 있습니다.)
    */
    void Start()
    {
        int a = 3;
        int b = 4;
        Debug.Log($"{a} + {b} = {Plus(a, b)}");
        float x = 2.4f;
        float y = 3.1f;
        Debug.Log($"{x} + {y} = {Plus(x, y)}");
    }
    public int Plus(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    public float Plus(float a, float b)
    {
        float sum = a + b;
        return sum;
    }
}
