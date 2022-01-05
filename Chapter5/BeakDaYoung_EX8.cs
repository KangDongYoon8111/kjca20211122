using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung_EX8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "03월";

        switch(a)
        {
            case "01월":
                Debug.Log("12월~02월 : 겨울");
                break;
            case "02월":
                Debug.Log("12월~02월 : 겨울");
                break;
            case "03월":
                Debug.Log("3월~05월 : 봄");
                break;
            case "04월":
                Debug.Log("3월~05월 : 봄");
                break;
            case "05월":
                Debug.Log("3월~05월 : 봄");
                break;
            case "06월":
                Debug.Log("6월~08월 : 여름");
                break;
            case "07월":
                Debug.Log("6월~08월 : 여름");
                break;
            case "08월":
                Debug.Log("6월~08월 : 여름");
                break;
            case "09월":
                Debug.Log("9월~11월 : 가을");
                break;
            case "10월":
                Debug.Log("9월~11월 : 가을");
                break;
            case "11월":
                Debug.Log("9월~11월 : 가을");
                break;
            case "12월":
                Debug.Log("12월~02월 : 겨울");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
