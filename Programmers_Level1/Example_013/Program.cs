namespace Example_013
{
    /// <summary>
    /// 날짜 : 2024-10-05
    /// 문제 : 나머지가 1이 되는 수 찾기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/87389
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            int x = 0;
            int answer = 0;


            


            for(int i = 2; i < n; i++)
            {
                if(n % i == 1)
                {
                    answer = i;
                    break;
                } 
            }

            Console.WriteLine(answer);

        }
    }
}
