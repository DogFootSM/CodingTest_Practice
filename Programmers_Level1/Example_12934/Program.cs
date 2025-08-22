namespace Example_12934
{
    /// <summary>
    /// 날짜 : 2024-10-07
    /// 문제 : 정수 제곱근 판별
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12934
    /// </summary>
    public class Solution
    {
        public long solution(long n)
        {

            long sqrt = (long)Math.Sqrt(n);
            long temp = (long)Math.Pow(sqrt, 2);
            long answer = temp == n ? (long)Math.Pow(sqrt + 1, 2) : -1;
             
            return answer;
        }
    }
}
