namespace Example_021
{
    /// <summary>
    /// 날짜 : 2024-08-06
    /// 문제 : 자릿수 더하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120906
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {

            char[] arr = n.ToString().ToCharArray();
            int answer = 0;

            foreach (char c in arr)
            {
                answer += int.Parse(c.ToString());
            }


            return answer;
        }
    }
}
