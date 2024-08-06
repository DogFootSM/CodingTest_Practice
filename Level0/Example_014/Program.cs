namespace Example_014
{


    /// <summary>
    /// 날짜 : 2024-08-06
    /// 문제 : 암호 해독
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120892
    /// </summary>
    public class Solution
    {
        public string solution(string cipher, int code)
        {
            string answer = "";
            int count = 0;

            for (int i = 0; i < cipher.Length; i++)
            {

                count++;
                if (count % code == 0)
                {

                    answer += cipher[i];
                }

            }

            return answer;
        }

    }
}
