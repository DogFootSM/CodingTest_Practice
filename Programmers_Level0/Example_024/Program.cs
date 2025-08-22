using System;

namespace Example_024
{
    /// <summary>
    /// 날짜 : 2024-08-07
    /// 문제 : 제곱수 판별하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120909
    /// </summary>

    public class Solution
    {
        public int solution(int n)
        {

            int num = 1;
            int answer = 0;
            while (num <= n)
            {
                if (num * num == n)
                {
                    answer = 1;
                    break;
                }
                else
                {
                    answer = 2;
                }
                num++;
            }

            return answer;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 144;

            int sqrt = (int)float.Sqrt(n);

            int answer = sqrt *= sqrt == n ? 1 : 2;
            
        }

        

    }
}
