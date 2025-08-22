namespace Example_035
{

    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 369 게임
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120891
    /// </summary>
    public class Solution
    {
        public int solution(int order)
        {
            int answer = 0;

            answer = order.ToString().Where(x => (int)(x - 48) % 3 == 0 && (int)(x - 48) != 0).Count();

            return answer;
        }
    }

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int order = 29423; 
            char[] crr = order.ToString().ToCharArray();
            int count = 0; 
            foreach (char c in crr)
            {
                if(c == '3' || c == '6' || c == '9')
                {
                    count++;
                }
            } 
            Console.WriteLine(count);

        }
    }
}
