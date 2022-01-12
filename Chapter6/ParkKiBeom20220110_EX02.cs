using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220110_EX02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 3;
        int b = 4;

        Debug.Log($"{a} + {b} = {Plus(a, b)}");

        float x = 2.4f;
        float y = 3.1f;

        Debug.Log($"{x} + {y} = {Plus(x, y)}");
    }

    public int Plus(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    public float Plus(float x, float y)
    {
        float sumf = x + y;
        return sumf;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
