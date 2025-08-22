namespace Example_86491
{

    /// <summary>
    /// 날짜 : 2024-10-23
    /// 문제 : 최소 직사각형
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/86491
    /// </summary>
    public class Solution
    {
        public int solution(int[,] sizes)
        {
            int answer = 0;
            int width = 0;
            int height = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    int temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp; 
                }

                width = width < sizes[i, 0] ? sizes[i, 0] : width;
                height = height < sizes[i, 1] ? sizes[i, 1] : height;

            }

            answer = width * height;


            return answer;
        }
    }
}
