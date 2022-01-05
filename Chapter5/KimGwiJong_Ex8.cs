using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex8 : MonoBehaviour
{
    //사용자에게 월을 입력받아 해당하는 계절을 
    //출력하는 프로그램을 만들어주세요.
    //03월~05월 : 봄, 06월~08월 : 여름,
    //09월~11월 : 가을, 12월~02월 : 겨울

    string input = "3월";

    void Start()
    {
        int month = int.Parse(input[0].ToString());
        


        switch (month)
        {
            case 1:
                Debug.Log("겨울");
                break;
            case 2:
                Debug.Log("겨울");
                break;
            case 3:
                Debug.Log("봄");
                break;
            case 4:
                Debug.Log("봄");
                break;
            case 5:
                Debug.Log("봄");
                break;
            case 6:
                Debug.Log("여름");
                break;
            case 7:
                Debug.Log("여름");
                break;
            case 8:
                Debug.Log("여름");
                break;
            case 9:
                Debug.Log("가을");
                break;
            case 10:
                Debug.Log("가을");
                break;
            case 11:
                Debug.Log("가을");
                break;
            case 12:
                Debug.Log("겨울");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
