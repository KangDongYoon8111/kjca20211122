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
            Debug.Log("4�г��� 70�� �̻��̸� �հ�");
        }
        else if (b<60)
        {
            Debug.Log("�� �̿��� �г��� 60�� �̻��̸� �հ�");
            
                }
        else
        {
            Debug.Log("���հ��Դϴ�.");
        }
        if (0 <= a && a <= 100)
            Debug.Log("���");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
