using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX5 : MonoBehaviour
{
//    광주초등학교에서 1학년부터 4학년까지 중간고사
//시험을 보았다.
//4학년은 70점 이상이면 합격, 그 이외의 학년은 60점
//이상이면 합격이다.
//이를 판단하는 프로그램을 만들어주세요.
//점수가 0미만 100초과이면 경고문구 출력
    // Start is called before the first frame update
    void Start()
    {
        int score = 50;
        int grade = 2;

        if( score < 0 || score > 100)
        {
            Debug.Log("잘못된 score입니다");
        }
        else if(grade==4)
        {
            if (score >= 70)
            {
                Debug.Log("합격");
            }
            else
            {
                Debug.Log("불합격");
            }
        }else if(grade<4 && grade >= 1)
        {
            if (score >= 60)
            {
                Debug.Log("합격");
            }
            else
            {
                Debug.Log("불합격");
            }
        }
        else
        {
            Debug.Log("잘못된 학년을 입력하셨습니다");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
