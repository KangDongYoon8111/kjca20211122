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
                Debug.Log("겨울");
                break;
            case "02":
                Debug.Log("겨울");
                break;
            case "03":
                Debug.Log("봄");
                break;
            case "04":
                Debug.Log("봄");
                break;
            case "05":
                Debug.Log("봄");
                break;
            case "06":
                Debug.Log("여름");
                break;
            case "07":
                Debug.Log("여름");
                break;
            case "08":
                Debug.Log("여름");
                break;
            case "09":
                Debug.Log("가을");
                break;
            case "10":
                Debug.Log("가을");
                break;
            case "11":
                Debug.Log("가을");
                break;
            case "12":
                Debug.Log("겨울");
                break;

        }
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
