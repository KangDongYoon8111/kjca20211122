using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 6;

        if(a%3==0)
        {
            Debug.Log("3의 배수 입니다.");
        }
        else
        {
            Debug.Log("3의 배수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
