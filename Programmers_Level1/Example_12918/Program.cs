namespace Example_12918
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 문자열 다루기 기본
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12918
    /// </summary>
    public class Solution
    {
        public bool solution(string s)
        {
            bool answer = int.TryParse(s, out int temp);
            return answer && (s.Length == 4 || s.Length == 6);
        }
    }
}
