using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 6;

        if(a%3==0)
        {
            Debug.Log("3�� ��� �Դϴ�.");
        }
        else
        {
            Debug.Log("3�� ����� �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
