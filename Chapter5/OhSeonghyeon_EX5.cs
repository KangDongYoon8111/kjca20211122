using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string userInput1 = "70"; //4학년
        int a = int.Parse(userInput1);
        string userInput2 = "59";  // 긔 외 학년
        int b = int.Parse(userInput2);
        int c = a + b;

        if (c <= 200)

        {
            if (a >= 70)
            { Debug.Log("합격"); }
            else if (a < 70)
            { Debug.Log("불합격"); }

            if (b >= 60)
            { Debug.Log("합격"); }
            else if (b < 60)
            { Debug.Log("불합격"); }
        }
            else
            {
                if (a < 0)
                { Debug.Log("0점 미만 경고"); }
                else if (a > 100)
                { Debug.Log("100점 초과 경고"); }
                if (b < 0)
                { Debug.Log("0점 미만 경고"); }
                else if (b > 100)
                { Debug.Log("100점 초과 경고"); }

            }

            // Update is called once per frame
            void Update()
            {

            }
    }
 }

