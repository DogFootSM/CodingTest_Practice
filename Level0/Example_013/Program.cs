namespace Example_013
{
    internal class Program
    {


        /// <summary>
        /// 날짜 : 2024-08-06
        /// 문제 : 문자열 안의 자연수들 덧셈
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120851
        /// </summary>
        public class Solution
        {
            public int solution(string my_string)
            {
                int answer = 0;

                foreach (char num in my_string)
                {

                    if (num >= 48 && num <= 57)
                    {
                        answer += (int)(num - 48);
                    }
                }

                return answer;
            }

           
        }

         
    }
}
