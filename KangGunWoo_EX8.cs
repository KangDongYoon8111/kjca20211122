using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX8 : MonoBehaviour
{
	//    ����ڿ��� ���� �Է¹޾� �ش��ϴ� ������
	//����ϴ� ���α׷��� ������ּ���.
	//03��~05�� : ��, 06�� ~08�� : ����,
	//09�� ~11�� : ����, 12�� ~02�� : �ܿ�

	// Start is called before the first frame update
	void Start()
	{
		int month = 7;

		switch (month)
		{ 
			case 12:
			case 1:
			case 2:
				Debug.Log($"{month}���� �ܿ��Դϴ�.");
				break;
			case 3:
			case 4:
			case 5:
				Debug.Log($"{month}���� ���Դϴ�.");
				break;
			case 6:
			case 7:
			case 8:
				Debug.Log($"{month}���� �����Դϴ�.");
				break;
			case 9:
			case 10:
			case 11:
				Debug.Log($"{month}���� �����Դϴ�.");
				break;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
