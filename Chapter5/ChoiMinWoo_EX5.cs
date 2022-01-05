using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_EX5 : MonoBehaviour
{
    public int grade;
    public int score;
    void Start()
    {
        if (grade == 4)
        {
            if (score <= 100 && score >= 70)
            {
                Debug.Log("합격입니다.");
            }
            else if (score < 70 && score >=0)
            {
                Debug.Log("불합격입니다.");
            }
            else
            {
                Debug.Log("0미만 100초과 입니다.");
            }   


        }
        else
        {
            if(score <= 100 && score >= 60)
           {
                Debug.Log("합격입니다.");
            }
            else if (score < 60 && score >= 0)
            {
                Debug.Log("불합격입니다.");
            }
            else
            {
                Debug.Log("0미만 100초과 입니다.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
