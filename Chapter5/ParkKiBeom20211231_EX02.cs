using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20211231_EX2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "50";
        int a = int.Parse(userInput);
        if (a >= 50)
        {
            Debug.Log("50 이상의 수입니다.");
        }
        else
        {
            Debug.Log("50 미만의 수입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
