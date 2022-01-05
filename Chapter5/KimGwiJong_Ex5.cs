using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex5 : MonoBehaviour
{
    // 광주초등학교에서 1학년부터 4학년까지 중간고사
    //시험을 보았다.
    //4학년은 70점 이상이면 합격, 그 이외의 학년은 60점
    //이상이면 합격이다.
    //이를 판단하는 프로그램을 만들어주세요.
    //점수가 0미만 100초과이면 경고문구 출력!

    string inputGrade = "5학년";
    string inputScore = "70";
    void Start()
    {

        int grade = int.Parse(inputGrade[0].ToString());
        int score = int.Parse(inputScore);

        if (score < 0 || score > 100)
        {
            Debug.Log($"점수입력 오류! 점수: {score}");
        }
        else if (grade == 4)
        { 
            if (score >= 70)
            {
                Debug.Log($"4학년 합격 점수: {score}");
            }

        }
        else if (grade >= 1 && grade < 4)
        {
            if (score >= 60)
            {
                Debug.Log($"{grade}학년 합격 점수: {score}");
            }
        }
        else
        {
            Debug.Log("학년입력오류");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
