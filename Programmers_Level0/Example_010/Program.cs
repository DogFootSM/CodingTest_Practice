namespace Example_010
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 문자열 안에 문자열 검사
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120908
    /// </summary>
    public class Solution
    {
        public int solution(string str1, string str2)
        {
            int answer = 2;

            if (str1.Contains(str2))
            {
                answer = 1;
            } 
            return answer;
        }
    }
}
