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
            Debug.Log("3의 배수입니다");
        }
        else
        {
            Debug.Log("3의 배수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
