using System.Text;

namespace Example_043
{
    /// <summary>
    /// 날짜 : 2024-08-10
    /// 문제 : 중복 문자 제거
    /// URL :https://school.programmers.co.kr/learn/courses/30/lessons/120888
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //중복 문자 제거
            string my_string = "We are the world";
            string answer = string.Concat(my_string.Distinct());

             
        }
    }
}
