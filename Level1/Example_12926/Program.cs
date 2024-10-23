using System.Text.RegularExpressions;

namespace Example_12926
{

    /// <summary>
    /// 날짜 : 2024-10-23
    /// 문제 : 시저 암호
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12926
    /// </summary>
    public class Solution
    {
        public string solution(string s, int n)
        {
            string answer = "";
            char[] crr = s.ToCharArray();


            for (int i = 0; i < s.Length; i++)
            {
                if (crr[i] == ' ')
                {
                    answer += ' ';
                    continue;
                }
                else if (char.IsLower(crr[i]) && (char)(crr[i] + n) > 'z')
                {
                    crr[i] = (char)(crr[i] - 26);

                }

                else if (char.IsUpper(crr[i]) && (char)(crr[i] + n) > 'Z')
                {
                    crr[i] = (char)(crr[i] - 26);
                }

                answer += string.Concat((char)(crr[i] + n));
            }


            return answer;
        }
    }
}
