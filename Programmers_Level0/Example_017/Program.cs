using System.Net.Http.Headers;

namespace Example_017
{
    /// <summary>
    /// 날짜 : 2024-08-06
    /// 문제 : n의 배수 고르기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120905
    /// </summary>
    public class Solution
    {
        //메서드 활용하여 큰 수 구하기
        public int[] solution(int n, int[] numlist)
        { 
            int[] answer = numlist.Where(x => x % n == 0).ToArray();

            return answer;
        }
    }
     

    internal class Program
    {
        //메서드 없이 큰 수 구하기
        static void Main(string[] args)
        {
            int n = 5;
            int[] numlist = { 1, 9, 3, 10, 13, 5 };
            int[] answer;
            int index = 0;
            int count = 0;
            for(int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {
                    index++;
                }
            }

            answer = new int[index];

            for(int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {

                    answer[count] = numlist[i];
                    count++;
                }

            }

            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }

        }
    }
}
