namespace Example_036
{
    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 약수 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120897
    /// </summary>
    public class Solution
    {

        public int[] solution(int n)
        {

            int[] arr;
            int count = 0;
            int index = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            arr = new int[count];

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {

                    arr[index++] = i;
                }
            }


            return arr;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 24;
            List<int> list = new List<int>();


            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
            } 
        }
    }
}
