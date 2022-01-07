using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeonEX8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string season = "3";
        int a = int.Parse(season);

        switch(season)
        {
            case "3":
             Debug.Log("3월은 봄입니다.");
                break;
            case "4":
                Debug.Log("4월은 봄입니다.");
                break;
            case "5":
                Debug.Log("5월은 봄입니다.");
                break;
            case "6":
                Debug.Log("6월은 여름입니다.");
                break;
            case "7":
                Debug.Log("7월은 여름입니다.");
                break;
            case "8":
                Debug.Log("8월은 여름입니다.");
                break;
            case "9":
                Debug.Log("9월은 가을입니다.");
                break;
            case "10":
                Debug.Log("10월은 가을입니다.");
                break;
            case "11":
                Debug.Log("11월은 가을입니다.");
                break;
            case "12":
                Debug.Log("12월은 겨울입니다.");
                break;
            case "1":
                Debug.Log("1월은 겨울입니다.");
                break;
            case "2":
                Debug.Log("2월은 겨울입니다.");
                break;
            default:
                Debug.Log($"{a} : 달력에 없는 달입니다.");
                break;

        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
