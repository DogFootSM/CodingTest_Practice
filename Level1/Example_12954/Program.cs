namespace Example_12954
{
    /// <summary>
    /// 날짜 : 2024-10-06
    /// 문제 : x만큼 간격이 있는 n개의 숫자
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12954
    /// </summary>
    public class Solution
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            long temp = 0;
            int index = 0;

            while (n > 0)
            {
                temp += x;
                answer[index++] = temp;
                n--;
            }

            return answer;
        }
    }
}
