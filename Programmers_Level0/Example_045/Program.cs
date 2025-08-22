namespace Example_045
{
    /// <summary>
    /// 날짜 : 2024-08-10
    /// 문제 : 진료순서 정하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120835
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] emergency)
        {
            int[] answer = new int[emergency.Length];
            int rank = 1;

            for (int i = 0; i < emergency.Length; i++)
            {
                for (int j = 0; j < emergency.Length; j++)
                {
                    if (emergency[i] < emergency[j])
                    {
                        rank++;
                    }

                }
                answer[i] = rank;
                rank = 1;

            }
            return answer;
        }
    }
}
