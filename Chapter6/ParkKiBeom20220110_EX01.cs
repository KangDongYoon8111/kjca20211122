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
        Debug.Log("��� : " + userInput1 + "�� �������� " + x + "�Դϴ�.");
        Debug.Log("��� : " + userInput2 + "�� �������� " + y + "�Դϴ�.");
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
