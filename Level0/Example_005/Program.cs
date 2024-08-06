namespace Example_005
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 순서쌍의 개수 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120836#
    /// </summary>
    public class Solution
    {
        public int Answer(int n)
        {
            int count = 1;
            int x = 2;
             
            while (x <= n)
            {
                if (n % x == 0)
                {
                    count++;
                }
                x++;
            }

            return count;
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
 


        }
    }
}
