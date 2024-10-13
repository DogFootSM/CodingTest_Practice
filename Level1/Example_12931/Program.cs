namespace Example_12931
{
    /// <summary>
    /// 날짜 : 2024-10-06
    /// 문제 : 자릿수 더하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12931
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            while (n >= 1)
            {

                answer += (n % 10);
                n /= 10;
            }


            return answer;
        }
    }
}
