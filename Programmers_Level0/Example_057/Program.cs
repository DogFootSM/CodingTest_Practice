namespace Example_057
{

    /// <summary>
    /// 날짜 : 2024-08-16
    /// 문제 : 이진수 더하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120885
    /// </summary>
    public class Solution
    {
        public string solution(string bin1, string bin2)
        {
            string answer = Convert.ToString(Convert.ToInt32(bin1, 2) + Convert.ToInt32(bin2, 2), 2);

            return answer;
        }
    }
}
