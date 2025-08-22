namespace Example_038
{

    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 문자열 정렬하기 (2)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120911
    /// </summary> 
    public class Solution
    {
        public string solution(string my_string)
        {

            List<char> list = new List<char>();

            list = my_string.ToLower().ToList();
            list.Sort();

            string answer = "";

            foreach (char c in list)
            {

                answer += c;
            }

            return answer;
        }
    }
}
