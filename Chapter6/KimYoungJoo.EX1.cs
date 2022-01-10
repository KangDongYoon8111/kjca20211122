 public string userInput1 = "3";
    void Start()
    {
        Debug.Log(Square());
    }

    int Square()
    {
        int number = int.Parse(userInput1);
        number *= number;
        return number;
    }
