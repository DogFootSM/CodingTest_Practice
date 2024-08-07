namespace Example_030
{

    /// <summary>
    /// 날짜 : 2024-08-07
    /// 문제 : 피나 나눠 먹기 (3)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120816
    /// </summary>
    public class Solution
    {
        public int solution(int slice, int n)
        { 
            int pizza = 1;

            while (slice * pizza < n)
            {
                pizza++;
            }

            return pizza;
        }
    }
}
