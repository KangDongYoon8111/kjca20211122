using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX5 : MonoBehaviour
{
    public int grade;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        if (grade >= 4)
        {
            if (score >= 70 && score <= 100)
            {
                Debug.Log("합격");
            }
            else if (score <= 100 && score >= 0)
            {
                Debug.Log("불합격");
            }
            else
            {
                Debug.Log("경고");
            }
        }
        if(grade <= 3 )
        {
            if (score >= 60 && score <= 100)
            {
                Debug.Log("합격");
            }
            else if (score <= 100 && score >= 0)
            {
                Debug.Log("불합격");
            }
            else
            {
                Debug.Log("경고");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
