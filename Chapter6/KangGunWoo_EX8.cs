using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX8 : MonoBehaviour
{
	//    사용자에게 월을 입력받아 해당하는 계절을
	//출력하는 프로그램을 만들어주세요.
	//03월~05월 : 봄, 06월 ~08월 : 여름,
	//09월 ~11월 : 가을, 12월 ~02월 : 겨울

	// Start is called before the first frame update
	void Start()
	{
		int month = 7;

		switch (month)
		{ 
			case 12:
			case 1:
			case 2:
				Debug.Log($"{month}월은 겨울입니다.");
				break;
			case 3:
			case 4:
			case 5:
				Debug.Log($"{month}월은 봄입니다.");
				break;
			case 6:
			case 7:
			case 8:
				Debug.Log($"{month}월은 여름입니다.");
				break;
			case 9:
			case 10:
			case 11:
				Debug.Log($"{month}월은 가을입니다.");
				break;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
