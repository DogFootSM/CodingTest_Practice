namespace Example_12917
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 문자열 내림차순으로 배치하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12917
    /// </summary>
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            char[] crr = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < (s.Length - i) - 1; j++)
                {
                    if (crr[j] < crr[j + 1])
                    {
                        char temp = crr[j];
                        crr[j] = crr[j + 1];
                        crr[j + 1] = temp; 
                    } 
                } 
            }

            answer += string.Concat(crr.Select(x => x.ToString()));
             
            return answer;
        }
    }
}
