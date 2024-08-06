namespace Example_012
{

    /// <summary>
    /// 날짜 : 2024-08-06
    /// 문제 : 문자열 모음 제거
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120849
    /// </summary>
    public class Solution
    {
        public string solution(string my_string)
        {
             
            string[] check = { "a", "e", "i", "o", "u" };

            foreach (string c in check)
            {
                my_string = my_string.Replace(c, "");

            }
             
            return my_string;
        }
    }

     
}
