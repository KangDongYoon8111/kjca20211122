1. i++와 ++i의 차이점은 무엇인가요? 

답: i++는 i가 먼저 출력되고 출력이 된 뒤에 i의 값이 올라간다.그리고 ++i는 더하기가 한번 진행되고 숫자가 표시되니 i값보다 1이 더해진 값이 나온다.

2. 각 출력문의 값을 적으세요
int i = 1;
Debug.Log(i = i + 1);	답 : 2
Debug.Log(i++);		답 : 2
Debug.Log(++i);		답 : 4
Debug.Log(i += 1);		답 : 5

3. 다음 코드에서 b는 어떤 값을 가질까요? 
int a = 10;
string b = a == 0 ? "가나다" : "ABC";

답 : "ABC"
