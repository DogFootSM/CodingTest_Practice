namespace Example_12922
{
    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 수박수박수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12922
    /// </summary>
    public class Solution
    {
        public string solution(int n)
        {
            string answer = "";

            for (int i = 0; i < n; i++)
            {
                answer += string.Concat((i % 2 == 0 ? '수' : '박'));
            }

            return answer;
        }
    }
}
