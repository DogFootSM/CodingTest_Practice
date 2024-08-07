using System.Text;

namespace Example_027
{
    public class Solution
    {
        /// <summary>
        /// 날짜 : 2024-08-07
        /// 문제 : 특정 문자 제거하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120826
        /// </summary>
        public string solution(string my_string, string letter)
        {

            StringBuilder sb = new StringBuilder(my_string);
            sb.Replace(letter, "");

            string answer = sb.ToString();



            return answer;
        }
    }
}
