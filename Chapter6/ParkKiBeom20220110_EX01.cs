using UnityEngine;

public class ParkKiBeom20220110_EX01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "3";
        string userInput2 = "34.2";
        int x = Leaf(int.Parse(userInput1));
        float y = AquaPlus(float.Parse(userInput2));
        Debug.Log("결과 : " + userInput1 + "의 제곱근은 " + x + "입니다.");
        Debug.Log("결과 : " + userInput2 + "의 제곱근은 " + y + "입니다.");
    }
    public int Leaf(int a)
    {
        a = a * a;
        return a;
    }
    public float AquaPlus(float a)
    {
        a = a * a;
        return a;
    }
    
}
