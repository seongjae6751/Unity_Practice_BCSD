using UnityEngine;
public class exercise03 : MonoBehaviour
{
    [SerializeField]
    private int x = 10;
    private void Awake()
    {
        int result = 0;
        int index = 1;
        while (index <= 100)
        {
            result += index;
            index++;
        }
        Debug.Log($"1 E 100x {result}");

        // 05. 반복문 for
        //// for 반복문에서 사용하는 index 변수는
        //// 반복문 내부에서 선언했기 때문에 지역변수로 취급되어
        //// 반복문이 종료되면 데이터가 사라진다.
        //for (int index = 0; index < 10; ++index)
        //{
        //    Debug.Log(index);
        //}

        //// 조건문과 마찬가지로 반복문도 중첩해서 사용 가능
        //for (int x = 1; x < 10; ++x)
        //{
        //    for (int y = 1; y < 10; ++y)
        //    {
        //        Debug.Log($"{x} x {y} = {x * y}");
        //    }
        //}

        // 04. 조건문 switch - case
        //x /= 10;

        //switch (x)
        //{
        //    case 10:
        //        Debug.Log("");
        //        break;
        //    case 9:
        //        Debug.Log("+");
        //        break;
        //    case 8:
        //        Debug.Log("+");
        //        break;
        //    case 7:
        //        Debug.Log("+");
        //        break;
        //    case 6:
        //        Debug.Log("");
        //        break;
        //    default:
        //        Debug.Log("");
        //        break;
        //}

        // 02. 조건문 if else
        //if (x >= 90)
        //{
        //    Debug.Log("학점 : A+");
        //}
        //else if (x >= 80)
        //{
        //    Debug.Log("학점 : B+");
        //}
        //else if (x >= 70)
        //{
        //    Debug.Log("학점 : C+");
        //}
        //else if (x >= 60)
        //{
        //    Debug.Log("학점 : D");
        //}
        //else
        //{
        //    Debug.Log("학점 : F");
        //}


        // 01. 조건문 if
        //if (x % 2 == 0)
        //{
        //    Debug.Log("x는 짝수다");
        //}

        //else
        //{
        //    Debug.Log("x는 홀수다");
        //}

        //// 앞에서 배운 연산자를 이용해 조건문 내부에
        //// 여러 개의 조건식을 동시에 만족하도록 설정 가능
        //if (x > 5 && x < 10)
        //{
        //    Debug.Log("x는 5보다 크고 10보다 작다");
        //}
        //// 조건문 내부에 중첩해서 조건문 작성 가능
        //// 위의 if 조건문과 같은 결과를 출력할 것이다
        //if (x > 5)
        //{
        //    if (x < 10)
        //    {
        //        Debug.Log("x는 5보다 크고 10보다 작다");
        //    }
        //}

        //Debug.Log($"x의 값은 {x}");
    }
}


