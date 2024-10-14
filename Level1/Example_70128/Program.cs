namespace Example_70128
{
    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 내적
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/70128
    /// </summary>
    public class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;

            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }


            return answer;
        }
    }
}
