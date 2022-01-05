using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunho_ex8 : MonoBehaviour
{
    public void Start()
    {
        string userInput = "4";
        int num1 = int.Parse(userInput);
        switch (num1)
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
            default:
                Debug.Log("1~12사이의 정수를 입력해주세요");
                break;
        }
    }
}
