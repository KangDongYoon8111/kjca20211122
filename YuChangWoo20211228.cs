using UnityEngine;

public class YuChangWoo20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        //이곳에 사각형의 넓이를 계산하고
        //출력하는 코드를 추가하세요.

        int c = int.Parse(a);
        int d = int.Parse(b);

        int e = (c * d);

        Debug.Log("이 사각형의 너비는"+a+"입니다.");
        Debug.Log("사각형의 높이는"+b+"입니다.");
        Debug.Log("사각형의 넓이는"+e+"입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
