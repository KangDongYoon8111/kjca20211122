using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 학점 안내 프로그램
        // 사용자의 점수를 입력받아 90점 이상으 "A",
        // 80점 이상은 "B", 70점 이상은 "C",
        // 69점 이하 점수는 "F"가 출력되는 프로그램을
        // 만들어 주세요.

        string inputText = "95";
        int jumsu = int.Parse(inputText);

        if(jumsu >= 90)
        {
            Debug.Log("A");
        }else if(jumsu >= 80)
        {
            Debug.Log("B");
        }else if (jumsu >= 70)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
