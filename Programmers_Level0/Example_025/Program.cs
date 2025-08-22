namespace Example_025
{
    public class Solution
    {
        /// <summary>
        /// 날짜 : 2024-08-07
        /// 문제 : 배열의 유사도
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120903
        /// </summary>
        public int solution(string[] s1, string[] s2)
        {
            int answer = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i].Equals(s2[j]))
                    {
                        answer++;
                    }
                }
            }


            return answer;
        }
    }
}
