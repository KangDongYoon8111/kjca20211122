using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int grade = 4;
        int score = 110;
        if (0 > score)
        {
            Debug.Log("���");
        }
        else if (score > 100)
        {
            Debug.Log("���");
        }
        else
        {
            if (grade == 4)
            {
                if (score >= 70)
                {
                    Debug.Log("�հ�");
                }
                else
                {
                    Debug.Log("���հ�");
                }
            }
            else
            {
                if (score >= 60)
                {
                    Debug.Log("�հ�");
                }
                else
                {
                    Debug.Log("���հ�");
                }
            }
        }

    }
}
