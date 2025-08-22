namespace Example_049
{

    /// <summary>
    /// 날짜 : 2024-08-11
    /// 문제 : A로 B만들기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120886
    /// </summary>
    public class Solution
    {
        public int solution(string before, string after)
        {
            int answer = 0;

            int beforeTotal = before.Sum(x => (int)x);
            int afterTotal = after.Sum(x => (int)x);

            answer = beforeTotal == afterTotal ? 1 : 0;

            return answer;
        }
    }
}
