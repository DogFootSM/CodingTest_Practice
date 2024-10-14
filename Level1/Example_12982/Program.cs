namespace Example_12982
{
    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 예산
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12982
    /// </summary>
    public class Solution
    {
        public int solution(int[] d, int budget)
        {
            int answer = 0;

            Array.Sort(d);

            for (int i = 0; i < d.Length; i++)
            {
                if (budget >= d[i])
                {
                    budget -= d[i];
                    answer++;
                } 
            } 
            return answer;
        }
    }
}
