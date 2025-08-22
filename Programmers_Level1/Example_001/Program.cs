namespace Example_001
{
    /// <summary>
    /// 날짜 : 2024-08-29
    /// 문제 : 직사각형 별찍기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12969
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] s; 
            s = Console.ReadLine().Split(' ');

            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             
        }
    }
}
