using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohsangmok_EX8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string season = "03월";

        switch (season)
        {
            case "01월":
                Debug.Log("겨울");
                break;
            case "02월":
                Debug.Log("겨울");
                break;
            case "03월":
                Debug.Log("봄");
                break;
            case "04월":
                Debug.Log("봄");
                break;
            case "05월":
                Debug.Log("봄");
                break;
            case "06월":
                Debug.Log("여름");
                break;
            case "07월":
                Debug.Log("여름");
                break;
            case "08월":
                Debug.Log("여름");
                break;
            case "09월":
                Debug.Log("가을");
                break;
            case "10월":
                Debug.Log("가을");
                break;
            case "1월":
                Debug.Log("가을");
                break;
            case "12월":
                Debug.Log("겨울");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
