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
                Debug.Log("�հ�");
            }
            else if (score <= 100 && score >= 0)
            {
                Debug.Log("���հ�");
            }
            else
            {
                Debug.Log("���");
            }
        }
        if(grade <= 3 )
        {
            if (score >= 60 && score <= 100)
            {
                Debug.Log("�հ�");
            }
            else if (score <= 100 && score >= 0)
            {
                Debug.Log("���հ�");
            }
            else
            {
                Debug.Log("���");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
