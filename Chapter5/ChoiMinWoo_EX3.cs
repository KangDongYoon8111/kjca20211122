using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_EX3 : MonoBehaviour
{
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        if(num % 3 ==0)
        {
            Debug.Log("3�� ����Դϴ�");
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
