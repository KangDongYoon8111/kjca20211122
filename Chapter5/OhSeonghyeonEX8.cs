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
             Debug.Log("3���� ���Դϴ�.");
                break;
            case "4":
                Debug.Log("4���� ���Դϴ�.");
                break;
            case "5":
                Debug.Log("5���� ���Դϴ�.");
                break;
            case "6":
                Debug.Log("6���� �����Դϴ�.");
                break;
            case "7":
                Debug.Log("7���� �����Դϴ�.");
                break;
            case "8":
                Debug.Log("8���� �����Դϴ�.");
                break;
            case "9":
                Debug.Log("9���� �����Դϴ�.");
                break;
            case "10":
                Debug.Log("10���� �����Դϴ�.");
                break;
            case "11":
                Debug.Log("11���� �����Դϴ�.");
                break;
            case "12":
                Debug.Log("12���� �ܿ��Դϴ�.");
                break;
            case "1":
                Debug.Log("1���� �ܿ��Դϴ�.");
                break;
            case "2":
                Debug.Log("2���� �ܿ��Դϴ�.");
                break;
            default:
                Debug.Log($"{a} : �޷¿� ���� ���Դϴ�.");
                break;

        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
