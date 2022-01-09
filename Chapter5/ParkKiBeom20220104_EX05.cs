using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220104_EX05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "4학년";
        string userInput2 = "4학년 이외의 학년";
        string userInput3 = "72";
        string grade = "4학년";
        int a = int.Parse(userInput3);

        if (grade == userInput1)
        {
            if (70 <= a && a <= 100 && 0 < a)
                Debug.Log(grade + "이며" + " " + a + "점으로 70점 이상이므로 합격!");
            else if (grade == userInput2)
            {
                if (60 <= a && a <= 100 && 0 < a)
                    Debug.Log(grade + "이며" + " " + a + "점으로 60점 이상이므로 합격!");
            }
            else if (0 > a)
            {
                Debug.Log("*경고 : 0점 미만입니다.");
            }
            else if (100 < a)
            {
                Debug.Log("*경고 : 100점을 초과 하였습니다.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
