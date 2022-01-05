using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20211231_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "15";
        int a = int.Parse(userInput);

        if ((a % 3) == 0)
            
        {
            Debug.Log("3의 배수가 맞습니다.");
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
