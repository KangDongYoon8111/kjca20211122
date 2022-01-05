using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220104_EX8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string season = "07월";

        switch (season)
        {
            case "01월":
                Debug.Log("01월은 겨울입니다.");
                break;
            case "02월":
                Debug.Log("02월은 겨울입니다.");
                break;
            case "03월":
                Debug.Log("03월은 봄입니다.");
                break;
            case "04월":
                Debug.Log("04월은 봄입니다.");
                break;
            case "05월":
                Debug.Log("05월은 봄입니다.");
                break;
            case "06월":
                Debug.Log("06월은 여름입니다.");
                break;
            case "07월":
                Debug.Log("07월은 여름입니다.");
                break;
            case "08월":
                Debug.Log("08월은 여름입니다.");
                break;
            case "09월":
                Debug.Log("09월은 가을입니다.");
                break;
            case "10월":
                Debug.Log("10월은 가을입니다.");
                break;
            case "11월":
                Debug.Log("11월은 가을입니다.");
                break;
            case "12월":
                Debug.Log("12월은 겨울입니다.");
                break;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
