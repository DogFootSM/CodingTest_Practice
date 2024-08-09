namespace Example_041
{

    /// <summary>
    /// 날짜 : 2024-08-09
    /// 문제 : 합성수 찾기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120846
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            bool isCheck = false;

            for (int i = 4; i <= n; i++)
            {

                for (int j = 2; j <= n; j++)
                {
                    if (i % j == 0 && i != j && !isCheck)
                    {
                        answer++;
                        isCheck = true;
                    }

                }
                isCheck = false;
            }
            return answer;
        }
    }
}
