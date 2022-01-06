using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhsangMok_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 90;
       

        if (a % 3== 0) //3로 나눈 나머지가 참일 때 (나머지가 0이 아닐 때)
        {
            Debug.Log("입력한 수는 3의 배수 입니다.");
        }
        else //3로 나눈 나머지가 거짓일 때 (나머지가 0일 때)
        {
            Debug.Log("입력한 수는 3의 배수가 아닙니다.");
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
