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

        // 05. �ݺ��� for
        //// for �ݺ������� ����ϴ� index ������
        //// �ݺ��� ���ο��� �����߱� ������ ���������� ��޵Ǿ�
        //// �ݺ����� ����Ǹ� �����Ͱ� �������.
        //for (int index = 0; index < 10; ++index)
        //{
        //    Debug.Log(index);
        //}

        //// ���ǹ��� ���������� �ݺ����� ��ø�ؼ� ��� ����
        //for (int x = 1; x < 10; ++x)
        //{
        //    for (int y = 1; y < 10; ++y)
        //    {
        //        Debug.Log($"{x} x {y} = {x * y}");
        //    }
        //}

        // 04. ���ǹ� switch - case
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

        // 02. ���ǹ� if else
        //if (x >= 90)
        //{
        //    Debug.Log("���� : A+");
        //}
        //else if (x >= 80)
        //{
        //    Debug.Log("���� : B+");
        //}
        //else if (x >= 70)
        //{
        //    Debug.Log("���� : C+");
        //}
        //else if (x >= 60)
        //{
        //    Debug.Log("���� : D");
        //}
        //else
        //{
        //    Debug.Log("���� : F");
        //}


        // 01. ���ǹ� if
        //if (x % 2 == 0)
        //{
        //    Debug.Log("x�� ¦����");
        //}

        //else
        //{
        //    Debug.Log("x�� Ȧ����");
        //}

        //// �տ��� ��� �����ڸ� �̿��� ���ǹ� ���ο�
        //// ���� ���� ���ǽ��� ���ÿ� �����ϵ��� ���� ����
        //if (x > 5 && x < 10)
        //{
        //    Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        //}
        //// ���ǹ� ���ο� ��ø�ؼ� ���ǹ� �ۼ� ����
        //// ���� if ���ǹ��� ���� ����� ����� ���̴�
        //if (x > 5)
        //{
        //    if (x < 10)
        //    {
        //        Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        //    }
        //}

        //Debug.Log($"x�� ���� {x}");
    }
}


