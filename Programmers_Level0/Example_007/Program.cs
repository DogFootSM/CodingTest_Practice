using System.Diagnostics;


namespace Example_007
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 옷가게 할인 받기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120818
    /// </summary>
    public class Solution
    {
        public int solution(int price)
        {

            if (price >= 500000)
            {
                price -= (int)Math.Ceiling(price * 0.2);
            }
            else if (price >= 300000)
            {
                price -= (int)Math.Ceiling(price * 0.1);
            }
            else if (price >= 100000)
            {
                price -= (int)Math.Ceiling(price * 0.05);
            }


            return price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
 
        }
    }
}
