﻿namespace Example_003
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 짝수 홀수 개수 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120824
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[2];

            int oddNum = 0;
            int evenNum = 0;

            foreach (int num in num_list)
            {
                 
                if (num % 2 == 0)
                {
                    answer[0] = evenNum += 1;
                }
                else
                {
                    answer[1] = oddNum += 1;
                }
            }

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);

            return answer;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] numList = [1, 2, 3, 4, 5];

            Console.WriteLine(solution.solution(numList));


        }
    }
}
