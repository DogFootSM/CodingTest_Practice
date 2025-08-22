namespace Example_12933
{
    /// <summary>
    /// 날짜 : 2024-10-06
    /// 문제 : 정수 내림차순으로 배치하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12933
    /// </summary>
    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;
            string temp = "";
            char[] crr = n.ToString().ToCharArray();
            Array.Sort(crr);

            for (int i = crr.Length - 1; i >= 0; i--)
            {
                temp += crr[i];
            }

            answer = Convert.ToInt64(temp);
            return answer;
        }
    }
}
