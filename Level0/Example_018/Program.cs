using System.Security.Cryptography;

namespace Example_018
{
    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 직각삼각형 출력하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120823
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            for(int i = 0; i <n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
