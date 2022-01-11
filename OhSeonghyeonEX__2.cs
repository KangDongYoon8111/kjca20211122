using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeonEX__2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 3;
        int b = 4;

        Debug.Log($"{a}+{b} = {Plus(a,b)}");

        float x = 2.4f;
        float y = 3.1f;

        Debug.Log($"{x}+{y} = {Plus(x, y)}");

    }
    public  int Plus(int a, int b)
    {

        int sum = a + b;
        return sum;
        
    }
    public float Plus(float x, float y)
    {

        float sum = x + y;
        return sum;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
