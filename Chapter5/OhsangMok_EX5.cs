using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhsangMok_EX5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int a = 70;
        int b = 60;
       

        if (a < 70) 
        {
            Debug.Log("4학년은 70점 이상이면 합격");
        }
        else if (b<60)
        {
            Debug.Log("그 이외의 학년은 60점 이상이면 합격");
            
                }
        else
        {
            Debug.Log("불합격입니다.");
        }
        if (0 <= a && a <= 100)
            Debug.Log("경고");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
