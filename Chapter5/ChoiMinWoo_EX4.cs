using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_EX4 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    int max;
    int min;
    int sum;
    int avg;
    // Start is called before the first frame update
    void Start()
    {
        max = Mathf.Max(num1, num2, num3);
        min = Mathf.Min(num1, num2, num3);
        sum = num1+num2+num3;
        avg = sum / 3;
        Debug.Log($"�ִ밪�� {max}�Դϴ�.");
        Debug.Log($"�ּҰ��� {min}�Դϴ�.");
        Debug.Log($"�հ�� {sum}�Դϴ�.");
        Debug.Log($"����� {avg}�Դϴ�.");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
