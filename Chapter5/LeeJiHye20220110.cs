using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJiHye20220110 : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        string Userinput = "4";
        string Userinput2 = "100";

        int grade = int.Parse(Userinput);
        int score = int.Parse(Userinput2);

        if (grade == 4)
        {
            if (score >= 70 && score <= 100)
            {
                Debug.Log("합격");
            }
            else if (score <= 69 && score >= 0)
            {
                Debug.Log("불합격");
            }
            else

            {
                Debug.Log("경고!");
            }


        }

        else
        {
            if (score >= 60 && score <= 100)
            {
                Debug.Log("합격");
            }
            else if (score <= 59 && score >= 0)
            {
                Debug.Log("불합격");
            }
            else
            {
                Debug.Log("경고!");
            }

        }

    }
}

