namespace Example_001
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : Lv.0 문자열 뒤집기 
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120822
    /// </summary>
    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            int num = my_string.Length - 1;

            for (int i = num; i >= 0; i--)
            {
                answer += my_string[i];
            }
             
            return answer;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
 
        }
    }
}
