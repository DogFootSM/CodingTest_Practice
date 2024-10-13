namespace Example_12928
{
    /// <summary>
    /// 날짜 : 2024-10-06
    /// 문제 : 약수의 합
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12928
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {
            int answer = n == 1 ? 1 : 0;

            for (int i = 1; i <= n / 2; i++)
            { 
                for (int j = n; j >= i; j /= i)
                { 
                    if (i * j == n)
                    {
                        answer += i == j ? j : (i + j);
                        break;
                    }
                }
            }

            //for(int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //        answer += i;
            //}

            return answer;
        }
    }
}
