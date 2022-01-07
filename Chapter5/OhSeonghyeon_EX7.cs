using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string Mouth = "11";
        int a = int.Parse(Mouth);
       

        
            switch (Mouth)

        {
            case "1":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("1월 : 31일까지 있습니다.");
                break;
            case "2":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("2월 : 28일 까지 있습니다.");
                break;
            case "3":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("3월 : 31일까지 있습니다.");
                break;
            case "4":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("4월 : 30일까지 있습니다.");
                break;
            case "5":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("5월 : 31일까지 있습니다.");
                break;
            case "6":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("6월 : 30일까지 있습니다.");
                break;
            case "7":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("7월 : 31일까지 있습니다.");
                break;
            case "8":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("8월 : 31일까지 있습니다.");
                break;
            case "9":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("9월 : 30일까지 있습니다.");
                break;
            case "10":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("10월 : 31일까지 있습니다.");
                break;
            case "11":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("11월 : 30일까지 있습니다.");
                break;
            case "12":
                Debug.Log($"몇월이 궁금하세요? {a}");
                Debug.Log("12월 : 31일까지 있습니다.");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
