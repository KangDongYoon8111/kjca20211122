using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userintput = "03";
        int x = int.Parse(userintput);

        switch (userintput)
        {
            case "01":
                Debug.Log("�ܿ�");
                break;
            case "02":
                Debug.Log("�ܿ�");
                break;
            case "03":
                Debug.Log("��");
                break;
            case "04":
                Debug.Log("��");
                break;
            case "05":
                Debug.Log("��");
                break;
            case "06":
                Debug.Log("����");
                break;
            case "07":
                Debug.Log("����");
                break;
            case "08":
                Debug.Log("����");
                break;
            case "09":
                Debug.Log("����");
                break;
            case "10":
                Debug.Log("����");
                break;
            case "11":
                Debug.Log("����");
                break;
            case "12":
                Debug.Log("�ܿ�");
                break;

        }
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
