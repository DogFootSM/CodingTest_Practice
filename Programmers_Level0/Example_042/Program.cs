namespace Example_042
{


    /// <summary>
    /// 날짜 : 2024-08-09
    /// 문제 : 피자 나눠 먹기 (2)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120815
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {

            int pizza = 1;
            int piece = 6;

            while (true)
            {

                if ((pizza * piece) % n == 0)
                {
                    break;
                }
                pizza++;

            }


            return pizza;
        }
    }
}
