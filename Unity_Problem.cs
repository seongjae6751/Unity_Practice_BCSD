using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unity_Problem : MonoBehaviour
{
    private void Awake()
    {
        //문제 19번
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

        
        //문제 18번
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


		//문제 17번
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


		//문제 16번
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


		//문제 15번
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


		//문제 14번
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


		//문제 13번
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


		//문제 12번
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


		//문제 11번
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


		//문제 10번
        // for (int y = 0; y < 26; ++y)
        // {
        //     string sentence = "";
        //     for (int x = 0; x <= y; ++x)
        //     {
        //         sentence += (char)(65 + x);
        //     }

        //     Debug.Log(sentence);
        // }


        // 문제 9번
        //for (int x = 1; x <= 5; x++)
        //{
        //    string sentence = "";
        //    for (int y = 0; y < 5 - x; y++)
        //    {
        //        sentence += "★";
        //    }
        //    for (int y = x - 1; y >= 0; y--)
        //    {
        //        sentence += "☆";
        //    }
        //    for (int y = 1; y < x; y++)
        //    {
        //        sentence += "☆";
        //    }
        //    for (int y = 5; y > x; y--)
        //    {
        //        sentence += "★";
        //    }
        //    Debug.Log(sentence);
        //}
        //for (int y = 0; y < 4; ++y)
        //{
        //    string sentence = "";

        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "★";
        //    }
        //    for (int x = y * 2; x < 4 * 2 - 1; ++x)
        //    {
        //        sentence += "☆";
        //    }
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "★";
        //    }

        //    Debug.Log(sentence);
        //}


        // 문제 8번
        //for (int x = 1; x <= 5; x++)
        //{
        //    string sentence = "";
        //    for (int y = 0; y < 5 - x; y++)
        //    {
        //        sentence += "☆";
        //    }
        //    for (int y = x - 1; y >= 0; y--)
        //    {
        //        sentence += "★";
        //    }
        //    for (int y = 1; y < x; y++)
        //    {
        //        sentence += "★";
        //    }
        //    for (int y = 5; y > x; y--)
        //    {
        //        sentence += "☆";
        //    }
        //    Debug.Log(sentence);
        //}
        //for (int y = 0; y < 4; ++y)
        //{
        //    string sentence = "";

        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "☆";
        //    }
        //    for (int x = y * 2; x < 4 * 2 - 1; ++x)
        //    {
        //        sentence += "★";
        //    }
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "☆";
        //    }

        //    Debug.Log(sentence);
        //}


        // 문제 7번
        //for (int i = 1; i <= 5; i++)
        //{
        //    string sentence = "";
        //    for (int j = 0; j < 5 - i; j++)
        //    {
        //        sentence += "☆";
        //    }
        //    for (int j = i - 1; j >= 0; j--)
        //    {
        //        sentence += "★";
        //    }
        //    for (int j = 1; j < i; j++)
        //    {
        //        sentence += "★";
        //    }
        //    for (int j = 5; j > i; j--)
        //    {
        //        sentence += "☆";
        //    }
        //    Debug.Log(sentence);
        //}


        //문제 6번
        //for ( int y = 0; y < 5; ++ y )
        //{
        //    string sentence = "";

        //    for ( int x = 0; x <= y; ++ x )
        //    {
        //        sentence += "★";
        //    }
        //    for ( int x = y; x < 5-1; ++ x )
        //    {
        //        sentence += "☆";
        //    }
        //    for ( int x = y; x < 5; ++ x )
        //    {
        //        sentence += "★";
        //    }
        //    for ( int x = 0; x < y; ++ x )
        //    {
        //        sentence += "☆";
        //    }

        //    Debug.Log(sentence);
        //}

        //for ( int y = 0; y < 5; ++ y )
        //{
        //    string sentence = "";

        //    for ( int x = y; x < 5-1; ++ x )
        //    {
        //        sentence += "☆";
        //    }
        //    for ( int x = 0; x <= y; ++ x )
        //    {
        //        sentence += "★";
        //    }
        //    for ( int x = 0; x < y; ++ x )
        //    {
        //        sentence += "☆";
        //    }
        //    for ( int x = y; x < 5; ++ x )
        //    {
        //        sentence += "★";
        //    }

        //    Debug.Log(sentence);
        //}



        // 문제 5번
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";

        //    for (int x = 0; x < y; ++x)
        //    {
        //        sentence += "☆";
        //    }

        //    for (int x = 5; x > y; x--)
        //    {
        //        sentence += "★";
        //    }

        //    Debug.Log(sentence);
        //}


        // 문제 4번
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";

        //    for (int x = y + 1; x < 5; ++x)
        //    {
        //        sentence += "☆";
        //    }

        //    for (int x = 0; x <= y ; ++x)
        //    {
        //        sentence += "★";
        //    }

        //    Debug.Log(sentence);
        //}


        // 문제 3번
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";
        //    for (int x = 5; x >= y; --x)
        //    {
        //        sentence += "★";
        //    }   
        //    for (int x = y+1; x < 5; ++x)
        //    {
        //        sentence += "☆";
        //    }
        //    Debug.Log(sentence);
        //}


        // 문제 2번
        //for (int y = 0; y < 5; ++y)
        //{
        //    string sentence = "";

        //    // 막힌별은 1, 2, 3, 4, 5 개수로 출력
        //    for (int x = 0; x <= y; ++x)
        //    {
        //        sentence += "★";
        //    }
        //    // 뚫린별은 4, 3, 2, 1, 0 개수로 출력         
        //    for (int x = y + 1; x < 5; ++x)
        //    {
        //        sentence += "☆";
        //    }
        //    Debug.Log(sentence);
        //}


        // 문제 1번
        //int sum = 0;
        //for (int i = 1; i<=10; i++)
        //{
        //    if (i % 3 != 0)
        //    {
        //        Debug.Log(string.Format("{0}", i));
        //        sum += i;
        //    }
        //}
        //Debug.Log ($"1~10중 3으로 나누어 떨어지지 않는 수의 합 : {sum}");
    }
}
