namespace Example_77884
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 약수의 개수와 덧셈
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/77884
    /// </summary>
    public class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            int count = 0;
             
            for (int i = left; i <= right; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                //약수의 개수가 짝수이면 + 홀수이면 -
                answer += count % 2 == 0 ? i : -i;
                count = 0;
            } 
            return answer;
        }
    }
}
