using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KImMinSu_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 7;
        if(a%3 == 0)
        {
            Debug.Log(a + "�� 3�ǹ���̴�.");
        }
        else
        {
            Debug.Log(a + "�� 3�ǹ���� �ƴϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
