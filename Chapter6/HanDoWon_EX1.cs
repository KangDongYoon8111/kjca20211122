using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
  void Start()
    {

        int userinput1 = 3;
        float userinput2 = 34.2f;

        Debug.Log($"��� : {userinput1} �� ���� ���� {x(userinput1*userinput1)} �Դϴ�.");
        Debug.Log($"��� : {userinput2} �� ���� ���� {x(userinput2*userinput2)} �Դϴ�.");
    }

    int x (int userinput1)
    {
        return userinput1 *userinput1;
    }

    float x(float userinput2)
    {
        return userinput2 * userinput2;
    }
}