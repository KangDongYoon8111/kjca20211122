using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userintput = "9";
        int y = int.Parse(userintput);
        string n = (y % 2) == 0 ? "30" : "31";
        string m = (y % 2) == 0 ? "31" : "30";




        switch (userintput)
        {
            case "1":
                Debug.Log(userintput + "���� : " + n + "�� ���� �ֽ��ϴ�.");
                break;
            case "2":
                Debug.Log(userintput + "���� : 28�� ���� �ֽ��ϴ�.");
                break;
            case "3":
                Debug.Log(userintput + "���� : " + n + "�� ���� �ֽ��ϴ�.");
                break;
            case "4":
                Debug.Log(userintput + "���� : " + n + "�� ���� �ֽ��ϴ�.");
                break;
            case "5":
                Debug.Log(userintput + "���� : " + n + "�� ���� �ֽ��ϴ�.");
                break;
            case "6":
                Debug.Log(userintput + "���� : " + n + "�� ���� �ֽ��ϴ�.");
                break;
            case "7":
                Debug.Log(userintput + "���� : " + n + "�� ���� �ֽ��ϴ�.");
                break;
            case "8":
                Debug.Log(userintput + "���� : " + m + "�� ���� �ֽ��ϴ�.");
                break;
            case "9":
                Debug.Log(userintput + "���� : " + m + "�� ���� �ֽ��ϴ�.");
                break;
            case "10":
                Debug.Log(userintput + "���� : " + m + "�� ���� �ֽ��ϴ�.");
                break;
            case "11":
                Debug.Log(userintput + "���� : " + m + "�� ���� �ֽ��ϴ�.");
                break;
            case "12":
                Debug.Log(userintput + "���� : " + m + "�� ���� �ֽ��ϴ�.");
                break;
              

        }
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
