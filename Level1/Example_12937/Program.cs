namespace Example_12937
{
    /// <summary>
    /// 날짜 : 2024-10-06
    /// 문제 : 짝수와 홀수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12937
    /// </summary>
    public class Solution
    {
        public string solution(int num)
        {
            string answer = "";

            if (num % 2 == 0)
            {
                answer = "Even";
            }

            else
            {
                answer = "Odd";
            }
             
            return answer;
        }
    }
}
