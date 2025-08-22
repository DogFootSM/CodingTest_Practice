namespace Example_12903
{
    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 가운데 글자 가져오기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12903
    /// </summary>
    public class Solution
    {
        public string solution(string s)
        {
            string answer = s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(s.Length / 2, 1);

            return answer;
        }
    }
}
