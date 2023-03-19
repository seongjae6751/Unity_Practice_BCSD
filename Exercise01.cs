using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Exercise01 : MonoBehaviour
{
    enum PlayerState{Idle, Move, Attack}
    private void Awake()
    {
        // Nullable
        int? intValue;

        intValue = null;
        Debug.Log(intValue.HasValue);
        //Debug. Log(intValue.Value); // ���� intValue�� null�̱� ������ ���� ����ϸ� ���� �߻�
        
        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        // var
        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valueString = "���ڿ�";
        
        Debug.Log("���� : " + valueInt);
        Debug.Log("�Ǽ� : " + valueFloat);
        Debug.Log("���ڿ� : " + valueString);


        // 13. �������� �̿��� �÷��̾� ���� ���� 
        //PlayerState playerState = PlayerState.Idle;
        //switch (playerState)
        //{
        //    case PlayerState.Idle:
        //        Debug.Log("�÷��̾� ���� : ���");
        //        break;
        //    case PlayerState.Move:
        //        Debug.Log("�÷��̾� ���� : �̵�");
        //        break;
        //    case PlayerState.Attack:
        //        Debug.Log("�÷��̾� ���� : ����");
        //        break;
        //}


        // 12. ����� �̿��� �÷��̾� ���� ����
        //const int PlayerIdle = 0;
        //const int PlayerMove = 1;
        //const int PlayerAttack = 2;

        //int playerState = PlayerAttack;

        //switch (playerState)
        //{
        //    case PlayerIdle:
        //        Debug.Log("�÷��̾� ���� : ���");
        //        break;
        //    case PlayerMove:
        //        Debug.Log("�÷��̾� ���� : �̵�");
        //        break;
        //    case PlayerAttack:
        //        Debug.Log("�÷��̾� ���� : ����");
        //        break;
        //}


        // 11. ���ڿ��� ���ڿ��� �� ��ȯ -ToString()
        //string stringValue = "";
        //int    intValue    = 33;
        //float  floatValue  = 12.3456f;

        //Debug.Log("stringValue: " + stringValue);

        //// ������ ���ڿ��� �� ��ȯ
        //stringValue = intValue.ToString();
        //Debug.Log("stringValue: " + stringValue);

        //// �Ǽ��� ���ڿ��� �� ��ȯ
        //stringValue = floatValue.ToString();
        //Debug.Log("stringValue: " + stringValue);


        // 10. ���ڿ��� ���ڷ� �� ��ȯ II - TryParse()
        //string stringValue = "";
        //int intValue = 10;

        //bool isConversion = int.TryParse(stringValue, out intValue);
        //if (isConversion == true)
        //{
        //    Debug.Log("stringValue : " + stringValue);
        //    Debug.Log("intValue: " + intValue);
        //}
        //else
        //{
        //    Debug.Log("stringValue ������ ����ִ� ������ ���ڰ� �ƴϾ ����ȯ�� �����Ͽ����ϴ�.");
        //}

        // 09. ���ڿ� ���ڷ� �� ��ȯ I - Parse
        //// ���ڿ�(string)�� ���ڰ� �ƴ� �����Ͱ� ������� ��� ���ڷ� �� ��ȯ�� �õ��ϸ� ���� �߻�
        //int intValue = 10;
        //float floatValue = 12.3456f;
        //string stringValue = "33";

        //Debug.Log("intValue : " + intValue);
        //Debug.Log("floatValue : " + floatValue);
        //Debug.Log("stringValue: " + stringValue);

        //// 33.4567�� ���� �Ǽ��� int�� �� ��ȯ �õ��ϸ� ���� �߻�
        ////stringValue = "33.4567";
        //intValue = int.Parse(stringValue);
        //stringValue = "33.4567";
        //floatValue = float.Parse(stringValue);

        //Debug.Log("intValue : " + intValue);
        //Debug.Log("floatValue : " + floatValue);
        //Debug.Log("stringValue : " + stringValue);


        // 08. �ε� �Ҽ����� ���� ������ �� ��ȯ
        //float floatValue = 0.9f;
        //int intValue = (int)floatValue;

        //Debug.Log("floatValue : " + floatValue);
        //Debug.Log("intValue : " + intValue);

        //floatValue = 1.1f;
        //intValue = (int)floatValue;

        //Debug.Log("floatValue : " + floatValue);
        //Debug.Log("intValue : " + intValue);


        // 07. ũ�Ⱑ ���� �ٸ� �ε� �Ҽ��� ������ �� ��ȯ
        //float floatValue = 69.6875f;
        //double doubleValue = (double)floatValue;

        //Debug.Log("floatValue : " + floatValue);
        //Debug.Log("doubleValue : " + doubleValue);

        //floatValue = 0.1f;
        //doubleValue = (double)floatValue;

        //Debug.Log("floatValue : " + floatValue);
        //Debug.Log("doubleValue : "+ doubleValue);


        // 06. ��ȣ �ִ� ������ ��ȣ ���� ���� ������ �� ��ȯ
        //sbyte sbyteValue = 31;
        //byte  byteValue = (byte)sbyteValue;

        //Debug.Log("sbyteValue : " + sbyteValue);
        //Debug.Log("byteValue : " + byteValue);

        //// Type02. ��ȣ �ִ� ������ ������ ��
        //sbyteValue = -31;
        //byteValue = (byte)sbyteValue;

        //Debug.Log("sbyteValue: " + sbyteValue);
        //Debug.Log("byteValue: " + byteValue);

        //// Type04. ��ȣ ���� ������ ��ȣ �ִ� ���� �ִ� ������ Ŭ ��
        //byteValue = 200;
        //sbyteValue = (sbyte)byteValue;

        //Debug.Log("sbyteValue : " + sbyteValue);
        //Debug.Log("byteValue : " + byteValue);

        //sbyte sbyteValue = 10;
        //int intValue = (int)sbyteValue;

        //Debug.Log("sbyteValue: " + sbyteValue);
        //Debug.Log("intValue : " + intValue);

        //// sbyte�� �ִ� ������ 127���� ū 130�� �����ϱ� ������ �����÷ο� �߻�
        //intValue = 130;                  // int - 21474836482147483647
        //sbyteValue = (sbyte)intValue;    //sbyte -128 ~ 127

        //Debug.Log("sbyteValue : "+ sbyteValue);
        //Debug.Log("intValue : " + intValue);


        //04. ������Ʈ ����
        //object valueInt = 31;                         // �ڽ� (����������)
        //object valueFloat = 3.14159265358979f;        // �ڽ� (����������)
        //object valueString = "��ü���� ���α׷���";     // �ڽ� (������ ����)
        //object valueBool = false;                     // �ڽ� (������ ����)


        //Debug.Log("���� : " + valueInt);              // ��ڽ� (������ ���)
        //Debug.Log("�Ǽ� : " + valueFloat);            // ��ڽ� (������ ���)
        //Debug.Log("���ڿ� :" + valueString);          // ��ڽ� (������ ���)
        //Debug.Log("�� : " + valueBool);             // ��ڽ� (������ ���)


        // 03. ���ڿ�, ��
        //string stringValue = "�ȳ��ϼ���. ��ڻ��Դϴ�.";
        //bool boolValue = true;

        //Debug.Log("string Data : " + stringValue);
        //Debug.Log("bool Data : " + boolValue);


        // 02. �Ǽ�
        //float floatValue01 = 3.141592653589793238462643383279f; // 7�ڸ� ǥ��
        //float floatValue02 = 31.141592653589793238462643383279f;// 7�ڸ� ǥ��
        //double doubleValue = 3.141592653589793238462643383279;  // 15�ڸ� ǥ��
        //decimal decimalValue = 3.141592653589793238462643383279m;// 29�ڸ� ǥ��

        //Debug.Log("float Data : " + floatValue01);
        //Debug.Log("float Data : " + floatValue02);
        //Debug.Log("double Data : " + doubleValue);
        //Debug.Log("decimal Data : " + decimalValue);


        // 01. ����
        //sbyte byteValue = -128;                     // -128 ~ 127
        //byte ubyteValue = 255;                      // 0 ~ 255
        //short shortValue = -32768;                  // -32768 ~ 32767
        //ushort ushortValue = 65535;                 // 0 ~ 65535
        //int intValue = -2147483648;                 // -2147483648 ~ 2147483647
        //uint uintValue = 4294967295;                // 0 ~ 4294967295
        //long longValue = -922337203685477508;       // -922337203685477508 ~ 922337203685477587
        //ulong ulongValue = 18446744073709551615;    // 0 ~ 18446744073709551615
        //char charValue = 'K';

        //Debug.Log("byte Data : " + byteValue);
        //Debug.Log("ubyte Data : " + ubyteValue);
        //Debug.Log("short Data : " + shortValue);
        //Debug.Log("ushort Data : " + ushortValue);
        //Debug.Log("int Data : " + intValue);
        //Debug.Log("uint Data : " + uintValue);
        //Debug.Log("long Data : " + longValue);
        //Debug.Log("ulong Data : " + ulongValue);
        //Debug.Log("char Data : " + charValue);
    }
}
  
  







