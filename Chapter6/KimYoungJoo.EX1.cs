  public string userInput1 = "3";
    public string userInput2 = "34.2";
    void Start()
    {
        Debug.Log("결과:"+userInput1+"의 제곱값은"+Square()+"입니다.");
        Debug.Log("결과:"+userInput2+"의 제곱값은"+Square()+"입니다.");
    }

    int Square()
    {
        int number = int.Parse(userInput1);    
        number *= number;
        return number;
  
    }
    int Square2()
    {
        int number2 = int.Parse(userInput2);
        number2 *= number2;
        return number2;
    }
