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
        Debug.Log($"최대값은 {max}입니다.");
        Debug.Log($"최소값은 {min}입니다.");
        Debug.Log($"합계는 {sum}입니다.");
        Debug.Log($"평균은 {avg}입니다.");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
