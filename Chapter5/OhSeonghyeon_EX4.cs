using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "50";
        int a = int.Parse(userInput1);
        string userInput2 = "60";
        int b = int.Parse(userInput2);
        string userInput3 = "70";
        int c = int.Parse(userInput3);
        int d = (a + b + c);

        string userInput4 = "3";
        int e = int.Parse(userInput4);
        



        if (a > 0)
        {
            if (a == 50)
            { Debug.Log("50 : 최솟값"); }

        }
        if (b > 0)
        {
            if (b == 60)
            { Debug.Log("60 : 중간값"); }


        }
        if (c > 0)
        {
            if (c == 70)
            { Debug.Log("70 :최댓값"); }

        }
        if (d > 0)
        {
            if (d > 0)
            { Debug.Log($"합계 : { a + b + c}"); } // { Debug.Log($"합계 : { d}"); }



        }

        if (e > 0)
        {

            if (e > 0)
            {
                Debug.Log($"평균 : {(a + b + c )/ e}");// { Debug.Log($"합계 : { d/e}"); }


            }

        }
    }
}
