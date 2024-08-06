namespace Example_006
{
    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 피자 나눠 먹기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120814
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {
            int pizza = 1;
            int piece = 7;

            while (piece * pizza < n)
            {
                pizza++;
            }

            return pizza;
        }



        public class Program
        {
            static void Main(string[] args)
            {


            }
        }
    }
}
