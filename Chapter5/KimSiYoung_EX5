using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimSiYoung_ex5 : MonoBehaviour
{
    // Start is called before the first frame update

    // 문제4. 
    //광주초등학교에서 1학년부터 4학년까지 중간고사
    //시험을 보았다.
    //4학년은 70점 이상이면 합격, 그 이외의 학년은 60점 이상이면 합격이다.
    //이를 판단하는 프로그램을 만들어주세요.
    //점수가 0미만 100초과이면 경고문구 출력!

    void Start()
    {
        string jam1 = "70"; //4학년
        string jam2 = "60"; //1,2,3학년

        int a = int.Parse(jam1);
        int b = int.Parse(jam2);

        if (b >= 60 && b >= 0 && b < 101)
        {
            Debug.Log("1학년 : 합격☆");
            Debug.Log("2학년 : 합격☆");
            Debug.Log("3학년 : 합격☆");
        }

        else if (b < 60 && b >= 0 && b < 101)
        {
            Debug.Log("1학년 : 불합격");
            Debug.Log("2학년 : 불합격");
            Debug.Log("3학년 : 불합격");
        }

        else
        {
            Debug.Log("1학년 : 점수를 잘못 입력하셨습니다.");
            Debug.Log("2학년 : 점수를 잘못 입력하셨습니다.");
            Debug.Log("3학년 : 점수를 잘못 입력하셨습니다.");
        }

        if (a >= 70 && a >= 0 && a < 101)
        {
            Debug.Log("4학년 : 합격☆");
        }

        else if (a < 70 && a >= 0 && a < 101)
        {
            Debug.Log("4학년 : 불합격");
        }

        else
        {
            Debug.Log("4학년 : 점수를 잘못 입력하셨습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
