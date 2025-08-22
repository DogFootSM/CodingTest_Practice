namespace Example_142086
{

    /// <summary>
    /// 날짜 : 2024-10-24
    /// 문제 : 가장 가까운 같은 글자
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/142086
    /// </summary>
    public class Solution
    {
        public int[] solution(string s)
        {
            int[] answer = new int[s.Length];

            answer[0] = -1;

            for (int i = 1; i < s.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (s[j].Equals(s[i]))
                    {
                        answer[i] = i - j;
                        break;
                    }
                    else
                    {
                        answer[i] = -1;
                    }
                } 
            } 
            return answer;
        }
    }
}
