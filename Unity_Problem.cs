using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unity_Problem : MonoBehaviour
{
    private void Awake()
    {
        //���� 19��
        //for (int y = 0; y < 26; ++y)
        //{
        //    string sentence = "";
        
        //    sentence += (char)(65 + y) + "\t";
        
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "  ";
        //    }
        
        //    int count = y * 3;
        //    for (int x = y; x < 26; ++x)
        //    {
        //        sentence += (char)(65 + count / 3);
        //        count++;
        //    }
        
        //    Debug.Log(sentence);
        //}

        
        //���� 18��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	sentence += (char)(65+y) + "\t";

		//	int count = 0;
		//	for ( int x = y; x < 26; ++ x )
		//	{
		//		sentence += (char)(65 + count / 3);
		//		count ++;
		//	}

		//	sentence += "  ";

		//	for ( int x = y; x < 26; ++ x )
		//	{
		//		sentence += (char)(65+x);
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 17��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	sentence += (char)(65+y) + "\t";

		//	int count = 0;
		//	for ( int x = y; x < 26; ++ x )
		//	{
		//		sentence += (char)(65 + count / 3);
		//		count ++;
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 16��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	sentence += (char)(65+y) + "\t";

		//	for ( int x = 0; x <= y; ++ x )
		//	{
		//		sentence += "  ";
		//	}

		//	for ( int x = y; x < 26 - y; ++ x )
		//	{
		//		sentence += (char)(65+x);
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 15��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	sentence += (char)(65+y) + "\t";

		//	for ( int x = 0; x < 26; ++ x )
		//	{
		//		sentence += (char)(65+x);
				
		//		if ( y == x )
		//		{
		//			sentence += (char)(65+x);
		//		}
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 14��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	sentence += (char)(65+y) + "\t";

		//	for ( int x = 0; x <= y; ++ x )
		//	{
		//		sentence += (char)(65+x);
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 13��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	sentence += (char)(65+y) + "\t";

		//	for ( int x = 0; x < y; ++ x )
		//	{
		//		sentence += "  ";
		//	}

		//	for ( int x = y; x < 26; ++ x )
		//	{
		//		sentence += (char)(65+x);
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 12��
		//for ( int y = 0; y < 26; ++ y )
		//{
		//	char alphabet = 'A';
		//	string sentence = "";

		//	for ( int x = 0; x < y; ++ x )
		//	{
		//		sentence += "  ";
		//	}

		//	for ( int x = 0; x <= y; ++ x )
		//	{
		//		sentence += alphabet;
		//		alphabet ++;
		//	}

		//	Debug.Log(sentence);
		//}


		//���� 11��
		//char alphabet = 'A';

		//for ( int y = 0; y < 26; ++ y )
		//{
		//	string sentence = "";

		//	for ( int x = 0; x <= y; ++ x )
		//	{
		//		sentence += alphabet;
		//	}

		//	Debug.Log(sentence);
			
		//	alphabet ++;
		//}


		//���� 10��
        // for (int y = 0; y < 26; ++y)
        // {
        //     string sentence = "";
        //     for (int x = 0; x <= y; ++x)
        //     {
        //         sentence += (char)(65 + x);
        //     }

        //     Debug.Log(sentence);
        // }


        // ���� 9��
        //for (int x = 1; x <= 5; x++)
        //{
        //    string sentence = "";
        //    for (int y = 0; y < 5 - x; y++)
        //    {
        //        sentence += "��";
        //    }
        //    for (int y = x - 1; y >= 0; y--)
        //    {
        //        sentence += "��";
        //    }
        //    for (int y = 1; y < x; y++)
        //    {
        //        sentence += "��";
        //    }
        //    for (int y = 5; y > x; y--)
        //    {
        //        sentence += "��";
        //    }
        //    Debug.Log(sentence);
        //}
        //for (int y = 0; y < 4; ++y)
        //{
        //    string sentence = "";

        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    for (int x = y * 2; x < 4 * 2 - 1; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "��";
        //    }

        //    Debug.Log(sentence);
        //}


        // ���� 8��
        //for (int x = 1; x <= 5; x++)
        //{
        //    string sentence = "";
        //    for (int y = 0; y < 5 - x; y++)
        //    {
        //        sentence += "��";
        //    }
        //    for (int y = x - 1; y >= 0; y--)
        //    {
        //        sentence += "��";
        //    }
        //    for (int y = 1; y < x; y++)
        //    {
        //        sentence += "��";
        //    }
        //    for (int y = 5; y > x; y--)
        //    {
        //        sentence += "��";
        //    }
        //    Debug.Log(sentence);
        //}
        //for (int y = 0; y < 4; ++y)
        //{
        //    string sentence = "";

        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    for (int x = y * 2; x < 4 * 2 - 1; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "��";
        //    }

        //    Debug.Log(sentence);
        //}


        // ���� 7��
        //for (int i = 1; i <= 5; i++)
        //{
        //    string sentence = "";
        //    for (int j = 0; j < 5 - i; j++)
        //    {
        //        sentence += "��";
        //    }
        //    for (int j = i - 1; j >= 0; j--)
        //    {
        //        sentence += "��";
        //    }
        //    for (int j = 1; j < i; j++)
        //    {
        //        sentence += "��";
        //    }
        //    for (int j = 5; j > i; j--)
        //    {
        //        sentence += "��";
        //    }
        //    Debug.Log(sentence);
        //}


        //���� 6��
        //for ( int y = 0; y < 5; ++ y )
        //{
        //    string sentence = "";

        //    for ( int x = 0; x <= y; ++ x )
        //    {
        //        sentence += "��";
        //    }
        //    for ( int x = y; x < 5-1; ++ x )
        //    {
        //        sentence += "��";
        //    }
        //    for ( int x = y; x < 5; ++ x )
        //    {
        //        sentence += "��";
        //    }
        //    for ( int x = 0; x < y; ++ x )
        //    {
        //        sentence += "��";
        //    }

        //    Debug.Log(sentence);
        //}

        //for ( int y = 0; y < 5; ++ y )
        //{
        //    string sentence = "";

        //    for ( int x = y; x < 5-1; ++ x )
        //    {
        //        sentence += "��";
        //    }
        //    for ( int x = 0; x <= y; ++ x )
        //    {
        //        sentence += "��";
        //    }
        //    for ( int x = 0; x < y; ++ x )
        //    {
        //        sentence += "��";
        //    }
        //    for ( int x = y; x < 5; ++ x )
        //    {
        //        sentence += "��";
        //    }

        //    Debug.Log(sentence);
        //}



        // ���� 5��
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";

        //    for (int x = 0; x < y; ++x)
        //    {
        //        sentence += "��";
        //    }

        //    for (int x = 5; x > y; x--)
        //    {
        //        sentence += "��";
        //    }

        //    Debug.Log(sentence);
        //}


        // ���� 4��
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";

        //    for (int x = y + 1; x < 5; ++x)
        //    {
        //        sentence += "��";
        //    }

        //    for (int x = 0; x <= y ; ++x)
        //    {
        //        sentence += "��";
        //    }

        //    Debug.Log(sentence);
        //}


        // ���� 3��
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";
        //    for (int x = 5; x >= y; --x)
        //    {
        //        sentence += "��";
        //    }   
        //    for (int x = y+1; x < 5; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    Debug.Log(sentence);
        //}


        // ���� 2��
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";

        //    // �������� 1, 2, 3, 4, 5 ������ ���
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    // �ո����� 4, 3, 2, 1, 0 ������ ���         
        //    for (int x = y + 1; x < 5; ++x)
        //    {
        //        sentence += "��";
        //    }
        //    Debug.Log(sentence);
        //}


        // ���� 1��
        //int sum = 0;
        //for (int i = 1; i<=10; i++)
        //{
        //    if (i % 3 != 0)
        //    {
        //        Debug.Log(string.Format("{0}", i));
        //        sum += i;
        //    }
        //}
        //Debug.Log ($"1~10�� 3���� ������ �������� �ʴ� ���� �� : {sum}");
    }
}
