using System.Data;
using System.Text;

namespace Example_040
{

    /// <summary>
    /// 날짜 : 2024-08-09
    /// 문제 : 외계행성의 나이
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120834
    /// </summary>
    public class Solution
    {
        public string solution(int age)
        {

            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            string answer = "";

            while (age > 0)
            {

                stack.Push(age % 10);
                age /= 10;

            }

            foreach (int i in stack)
            {
                sb.Append(((char)(i + 97)).ToString());

            }
            answer = sb.ToString();
            return answer;
        }

    }
}