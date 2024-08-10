namespace Example_044
{
    /// <summary>
    /// 날짜 : 2024-08-10
    /// 문제 : 2차원으로 만들기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120842
    /// </summary>
    public class Solution
    {
        public int[,] solution(int[] num_list, int n)
        {
            int[,] answer;
            int ySize = num_list.Length / n;
            int arrIndex = 0;
            answer = new int[ySize, n];

            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    answer[i, j] = num_list[arrIndex++];
                }
            }
            return answer;
        }
    }
}
